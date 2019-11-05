namespace OOP
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }

        public bool ValidarCnpj()
        {
            if (CNPJ.Length == 14)
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
            //
           // base.PodoSerSobreescrito();

            //
        }
    }
}
