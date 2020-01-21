public double CalculoSeguro()
    {
        if (CalcularIdade() > 5)
        {
            return (this.valorV * aliqSeguro) - Desconto();
        }
        else
        {
            return this.valorV * aliqSeguro;
        }
    }
	
    public Veiculo MaiorDespesa()
    {
            //Veiculo aux = carros[0];
            //for (int i = 0; i < carros.Length; i++)
            //{
            //    if(carros[i].DespesaTotal() > aux.DespesaTotal())
            //    {
            //        aux = carros[i];
            //    }
            //}

            //for (int i = 0; i < vans.Length; i++)
            //{
            //    if (vans[i].DespesaTotal() > aux.DespesaTotal())
            //    {
            //        aux = vans[i];
            //    }
            //}

            //for (int i = 0; i < caminhoes.Length; i++)
            //{
            //    if (caminhoes[i].DespesaTotal() > aux.DespesaTotal())
            //    {
            //        aux = caminhoes[i];
            //    }
            //}

            //return aux;

            Veiculo aux = frota[0];

            for (int i = 0; i < frota.Length; i++)
            {
                if (frota[i].DespesaTotal() > aux.DespesaTotal())
                {
                    aux = frota[i];
                }
            }

            return aux;
        }
		
public double TotalDespesa()
    {
        double aux = 0;
        for (int i = 0; i < frota.Length; i++)
        {
            aux += frota[i].DespesaTotal();
        }
        return aux;
    }