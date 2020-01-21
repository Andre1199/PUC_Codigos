public virtual bool Aprovado(int pos)
    {
        if (disciplinas[pos].NotaFinal() >= this.media)
        {
            return true;
        }
        else
        {
            return false;
        }    
    }
		
public void ImprimirHistorico()
    {
        for (int i = 0; i < disciplinas.Length; i++)
        {
            if (Aprovado(i))
            {
                disciplinas[i].ImprimirNotas();
            }
        }
    }