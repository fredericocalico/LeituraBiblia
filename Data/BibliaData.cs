namespace Biblia.Data;

public class BibliaData
{
     public static readonly List<Livro> Livros = new()
  {
    // Velho Testamento
    new("Gênesis", "Velho", 50), new("Êxodo", "Velho", 40), new("Levítico", "Velho", 27),
    new("Números", "Velho", 36), new("Deuteronômio", "Velho", 34), new("Josué", "Velho", 24),
    new("Juízes", "Velho", 21), new("Rute", "Velho", 4), new("1 Samuel", "Velho", 31),
    new("2 Samuel", "Velho", 24), new("1 Reis", "Velho", 22), new("2 Reis", "Velho", 25),
    new("1 Crônicas", "Velho", 29), new("2 Crônicas", "Velho", 36), new("Esdras", "Velho", 10),
    new("Neemias", "Velho", 13), new("Ester", "Velho", 10), new("Jó", "Velho", 42),
    new("Salmos", "Velho", 150), new("Provérbios", "Velho", 31), new("Eclesiastes", "Velho", 12),
    new("Cântico dos Cânticos", "Velho", 8), new("Isaías", "Velho", 66), new("Jeremias", "Velho", 52),
    new("Lamentações", "Velho", 5), new("Ezequiel", "Velho", 48), new("Daniel", "Velho", 12),
    new("Oséias", "Velho", 14), new("Joel", "Velho", 3), new("Amós", "Velho", 9),
    new("Obadias", "Velho", 1), new("Jonas", "Velho", 4), new("Miquéias", "Velho", 7),
    new("Naum", "Velho", 3), new("Habacuque", "Velho", 3), new("Sofonias", "Velho", 3),
    new("Ageu", "Velho", 2), new("Zacarias", "Velho", 14), new("Malaquias", "Velho", 4),

    // Novo Testamento
    new("Mateus", "Novo", 28), new("Marcos", "Novo", 16), new("Lucas", "Novo", 24),
    new("João", "Novo", 21), new("Atos", "Novo", 28), new("Romanos", "Novo", 16),
    new("1 Coríntios", "Novo", 16), new("2 Coríntios", "Novo", 13), new("Gálatas", "Novo", 6),
    new("Efésios", "Novo", 6), new("Filipenses", "Novo", 4), new("Colossenses", "Novo", 4),
    new("1 Tessalonicenses", "Novo", 5), new("2 Tessalonicenses", "Novo", 3), new("1 Timóteo", "Novo", 6),
    new("2 Timóteo", "Novo", 4), new("Tito", "Novo", 3), new("Filemom", "Novo", 1),
    new("Hebreus", "Novo", 13), new("Tiago", "Novo", 5), new("1 Pedro", "Novo", 5),
    new("2 Pedro", "Novo", 3), new("1 João", "Novo", 5), new("2 João", "Novo", 1),
    new("3 João", "Novo", 1), new("Judas", "Novo", 1), new("Apocalipse", "Novo", 22),
  };
}

public record Livro(string Nome, string Testamento, int Capitulos);