var supermercado = new ItemFinanceiro
{
    descricao = "Supermercado",
    valor = 2100,
    categoria = "Alimentação",
};
Console.WriteLine(supermercado.descricao);
Console.WriteLine(supermercado.valor);
Console.WriteLine(supermercado.categoria);


var vivo = new ItemFinanceiro
{
    descricao = "VIVO",
    valor = 425,
    categoria = "Comunicação",
};
Console.WriteLine(vivo.descricao);
Console.WriteLine(vivo.valor);
Console.WriteLine(vivo.categoria);


var condominio = new ItemFinanceiro
{
    descricao = "Condomínio",
    valor = 715,
    categoria = "Fixo",
};
Console.WriteLine(condominio.descricao);
Console.WriteLine(condominio.valor);
Console.WriteLine(condominio.categoria);


var ir = new ItemFinanceiro
{
    descricao = "Imposto Renda",
    valor = 980,
    categoria = "Fixo",
};

Console.WriteLine(ir.descricao);
Console.WriteLine(ir.valor);
Console.WriteLine(ir.categoria);

var luz = new ItemFinanceiro
{
    descricao = "LUZ",
    valor = 280,
    categoria = "Fixo",

};
Console.WriteLine(luz.descricao);
Console.WriteLine(luz.valor);
Console.WriteLine(luz.categoria);

var banesteVisa = new ItemFinanceiro
{
    descricao = "Baneste Visa",
    valor = 250,
    categoria = "Cartão",

};
Console.WriteLine(banesteVisa.descricao);
Console.WriteLine(banesteVisa.valor);
Console.WriteLine(banesteVisa.categoria);

var sx = new ItemFinanceiro
{
    descricao = "SX",
    valor = 397,
    categoria = "Cartão"
};
Console.WriteLine(sx.descricao);
Console.WriteLine(sx.valor);
Console.WriteLine(sx.categoria);

var santander = new ItemFinanceiro
{
    descricao = "Santander Mastercard",
    valor = 2000,
    categoria = "Cartão",

};
Console.WriteLine(santander.descricao);
Console.WriteLine(santander.valor);
Console.WriteLine(santander.categoria);

var bv = new ItemFinanceiro
{
    descricao = "BV",
    valor = 530,
    categoria = "Cartão"

};

Console.WriteLine(bv.descricao);
Console.WriteLine(bv.valor);
Console.WriteLine(bv.categoria);

var seguros = new ItemFinanceiro
{
    descricao = "Seguro casa, carro e vida",
    valor = 380,
    categoria = "Fixo",
};

Console.WriteLine(seguros.descricao);
Console.WriteLine(seguros.valor);
Console.WriteLine(seguros.categoria);


var emprestimos = new ItemFinanceiro
{
    descricao = "Emprestimos",
    valor = 2800,
    categoria = "Fixo",

};
Console.WriteLine(emprestimos.descricao);
Console.WriteLine(emprestimos.valor);
Console.WriteLine(emprestimos.categoria);


var carro = new ItemFinanceiro
{
    descricao = "Financiamento Carro",
    valor = 1687,
    categoria = "Fixo",
};

Console.WriteLine(carro.descricao);
Console.WriteLine(carro.valor);
Console.WriteLine(carro.categoria);


var academia = new ItemFinanceiro
{
    descricao = "Academia",
    valor = 330,
    categoria = "Fixo",

};
Console.WriteLine(academia.descricao);
Console.WriteLine(academia.valor);
Console.WriteLine(academia.categoria);


var faxineira = new ItemFinanceiro
{
    descricao = "Faxineira",
    valor = 340,
    categoria = "Fixo",

};

Console.WriteLine(faxineira.descricao);
Console.WriteLine(faxineira.valor);
Console.WriteLine(faxineira.categoria);


var psiquiatra = new ItemFinanceiro
{
    descricao = "Psiquiatra",
    valor = 700,
    categoria = "Saúde",

};
Console.WriteLine(psiquiatra.descricao);
Console.WriteLine(psiquiatra.valor);
Console.WriteLine(psiquiatra.categoria);


var mae = new ItemFinanceiro
{
    descricao = "Mãe",
    valor = 500,
    categoria = "Fixo"
};
Console.WriteLine(mae.descricao);
Console.WriteLine(mae.valor);
Console.WriteLine(mae.categoria);



var banestesMae = new EntradaDeDinheiro
{
    fontePagadora = "Banestes Mãe",
    valor = 3800,
};
Console.WriteLine(banestesMae.fontePagadora);
Console.WriteLine(banestesMae.valor);

var bancoBrasil = new EntradaDeDinheiro
{
    fontePagadora = "Banco do Brasil",
    valor = 4200,
};

Console.WriteLine(bancoBrasil.fontePagadora);
Console.WriteLine(bancoBrasil.valor);

var henrique = new EntradaDeDinheiro
{
    fontePagadora = "Henrique",
    valor = 1200,

};
Console.WriteLine(henrique.fontePagadora);
Console.WriteLine(henrique.valor);

var kiko = new EntradaDeDinheiro
{
    fontePagadora = "Kiko",
    valor = 1470,

};
Console.WriteLine(kiko.fontePagadora);
Console.WriteLine(kiko.valor);

var monique = new EntradaDeDinheiro
{
    fontePagadora = "Monique",
    valor = 1500,
};
 
Console.WriteLine(monique.fontePagadora);
Console.WriteLine(monique.valor);


//para evitar que o programa feche automaticamente
Console.ReadKey();