namespace DotPharma.Abstract
{
    public readonly struct CPF
    {
        public readonly string Value;

        public CPF(string value)
        {
            Value = value;
        }

        public static implicit operator string(CPF cpf)
        {
            return cpf.Value;
        }
    }

    public readonly struct RG
    {
        public readonly string Value;

        public RG(string value)
        {
            Value = value;
        }
    }
}