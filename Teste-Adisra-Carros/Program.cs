using System;

class Carro
{
    public int NumeroChassi { get; set; }
    public int NumeroMotor { get; set; }
    public double CustoProducao { get; set; }

    public virtual double CalcularImposto()
    {
        return CustoProducao * 0.2;
    }

    public virtual double CalcularCustoVenda()
    {
        double imposto = CalcularImposto();
        double lucro = CustoProducao * 0.25;
        return CustoProducao + imposto + lucro;
    }
}

class CarroFlex : Carro
{
    public int NumeroPortas { get; set; }
    public double Cilindrada { get; set; }

    public override double CalcularCustoVenda()
    {
        double imposto = CalcularImposto();
        double lucro = CustoProducao * 0.25;
        return CustoProducao + imposto + lucro;
    }
}

class CarroDiesel : Carro
{
    public double CapacidadeCarga { get; set; }
    public double VolumeCacamba { get; set; }

    public override double CalcularImposto()
    {
        return CustoProducao * 0.3;
    }

    public override double CalcularCustoVenda()
    {
        double imposto = CalcularImposto();
        double lucro = CustoProducao * 0.25;
        return CustoProducao + imposto + lucro;
    }
}

class CarroEletrico : Carro
{
    public double Potencia { get; set; }
    public double DuracaoBateria { get; set; }

    public override double CalcularImposto()
    {
        return CustoProducao * 0.1;
    }

    public override double CalcularCustoVenda()
    {
        double imposto = CalcularImposto();
        double lucro = CustoProducao * 0.25;
        return CustoProducao + imposto + lucro;
    }
}