public class Espanhol : Cursos
{
    public Espanhol(string aluno, int cargaHoraria, int custo) : base(aluno, cargaHoraria, custo)
    {

    }
    
    public string ObterCertificado()
    {
        return $"------------------Certificado-------------------\n O aluno {Aluno} concluiu com sucesso o curso de francês";
    }
}