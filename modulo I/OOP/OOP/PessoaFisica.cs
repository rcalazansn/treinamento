namespace OOP
{ 
    public class PessoaFisica: Pessoa
    {
        public string CPF { get; set; }

        public bool ValidarCpf()
        {
            if (CPF.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void PodoSerSobreescrito()
        {
            base.PodoSerSobreescrito();
        }
    }
}
