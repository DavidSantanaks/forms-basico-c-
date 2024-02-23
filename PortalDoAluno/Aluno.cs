namespace PortalDoAluno
{
    public class Aluno
    {

        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Curso { get; private set; }

        public Aluno(string nome, string idade, string curso)
        {


            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Nome é obrigatorio");
            }
            if (string.IsNullOrEmpty(idade))
            {
                throw new Exception("Idade é obrigatorio");
            }
            if (string.IsNullOrEmpty(curso))
            {
                throw new Exception("Curso é obrigatorio");
            }

            Nome = nome;
            Idade = int.Parse(idade);
            Curso = curso;
        }

    }
}
