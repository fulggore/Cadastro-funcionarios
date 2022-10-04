  class Funcionario
    {
    private int id;
    private string nome;
    private string cargo;
    private float salario;
    private Endereco endereco;
    

    //métodos construtor 1
    public Funcionario()
    {
        this.id = 0;
        this.nome = "";
        this.cargo = "";
        this.salario = 0f;
        this.endereco = new Endereco();
    }
    //métodos construtor 2
    public Funcionario(int par_id, string par_nome, string par_cargo, float par_salario, string par_logradouro, 
        string par_numero, string par_complemento, string par_cep)
    
    {
        this.id = par_id;
        this.nome = par_nome;
        this.cargo = par_cargo;
        this.salario = par_salario;
        this.endereco.logradouro = par_logradouro;
        this.endereco.numero = par_numero;
        this.endereco.complemento = par_complemento;
        this.endereco.cep = par_cep;

    }
        //método
        public int getId()
        {
        return this.id;
        }
        public void setId(int par_id)
         {
        this.id = par_id;
        }
        public string getNome()
        {
        return this.nome;
        }
        public void setNome(string par_nome)
         {
        this.nome = par_nome;
        }
        public string getCargo()
        {
        return this.cargo;
        }
        public void setCargo(string par_cargo)
         {
        this.cargo = par_cargo;
        }

        public float getSalario()
        {
        return this.salario;
        }
        public void setSalario(float par_salario)
         {
        this.salario = par_salario;
        }
        public string getLogradouro()
        {
        return this.endereco.logradouro;
        }
        public void setLogradouro(string par_logradouro)
         {
        this.endereco.logradouro = par_logradouro;
        }
        public string getNumero()
        {
             return this.endereco.numero;
        }
        public void setNumero(string par_numero)
         {
            this.endereco.numero = par_numero;
        }
        public string getComplemento()
        {
            return this.endereco.complemento;
        }
        public void setComplemento(string par_complemento)
         {
            this.endereco.complemento = par_complemento;
        }
        public string getCep()
        {
            return this.endereco.cep;
        }
        public void setCep(string par_cep)
         {
            this.endereco.cep = par_cep;
        }


}
