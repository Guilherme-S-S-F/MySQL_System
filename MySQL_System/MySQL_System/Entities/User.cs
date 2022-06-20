namespace MySQL_System
{
    public class User
    {
        int id;
        string nome;
        string usuario;
        string senha;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}