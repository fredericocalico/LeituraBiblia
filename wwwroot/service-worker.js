// service-worker.js (dev) – deixa o SW ativo, mas sem cache agressivo
self.addEventListener('install', () => self.skipWaiting());
self.addEventListener('activate', () => self.clients.claim());
