public class Ingles : Cursos
{
    public bool CertificadoTecnico { get; set; }

    public Ingles(string aluno, int cargaHoraria, int custo) : base(aluno, cargaHoraria, custo)
    {
    }

    public override string ToString()
    {
        string certificado = CertificadoTecnico ? "Possui certificado técnico" : "Não possui certificado técnico";
        return base.ToString() + $", {certificado}";
    }
}
//Usado o gemini e o chatgpt para completar e dar ideias e tendo o public override string ToString...

