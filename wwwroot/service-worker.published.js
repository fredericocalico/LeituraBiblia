// service-worker.published.js
self.importScripts('./service-worker-assets.js');

const CACHE_VERSION = self.assetsManifest ? self.assetsManifest.version : 'v1';
const CACHE_NAME = 'offline-cache-' + CACHE_VERSION;

// URLs a pré-cachear (assets do Blazor + página inicial)
const ASSETS = self.assetsManifest
    ? self.assetsManifest.assets.map(a => new URL(a.url, self.location).toString())
    : [];
ASSETS.push('./', './index.html');

self.addEventListener('install', event => {
    self.skipWaiting();
    event.waitUntil(
        caches.open(CACHE_NAME).then(cache => cache.addAll(ASSETS))
    );
});

self.addEventListener('activate', event => {
    event.waitUntil(
        (async () => {
            const keys = await caches.keys();
            await Promise.all(keys.map(k => (k === CACHE_NAME ? undefined : caches.delete(k))));
            await self.clients.claim();
        })()
    );
});

// Estratégia: cache-first para GET; navegações caem no index.html quando offline
self.addEventListener('fetch', event => {
    if (event.request.method !== 'GET') return;

    const req = event.request;

    // Navegação de páginas (HTML): tenta rede, senão index.html do cache
    if (req.mode === 'navigate') {
        event.respondWith(
            (async () => {
                try {
                    return await fetch(req);
                } catch {
                    return await caches.match('index.html');
                }
            })()
        );
        return;
    }

    // Demais requisições: cache-first
    event.respondWith(
        caches.match(req).then(cached => cached || fetch(req))
    );
});
