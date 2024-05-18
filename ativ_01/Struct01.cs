namespace Struct01;

public struct JogadorFutebol
{
    public string nome;
    public int idade;
    public string posicao;
    public string clube;
    public int numeroGols;
    public int numeroAssistencias;
    public int numeroCartoesAmarelos;
    public int numeroCartoesVermelhos;

    public JogadorFutebol(string nome, int idade, string posicao, string clube, int numeroGols, int numeroAssistencias, int numeroCartoesAmarelos, int numeroCartoesVermelhos)
    {
        this.nome = nome;
        this.idade = idade;
        this.posicao = posicao;
        this.clube = clube;
        this.numeroGols = numeroGols;
        this.numeroAssistencias = numeroAssistencias;
        this.numeroCartoesAmarelos = numeroCartoesAmarelos;
        this.numeroCartoesVermelhos = numeroCartoesVermelhos;
    }

    public void RegistrarNumeroCartoesAmarelos()
    {
        numeroCartoesAmarelos++;
    }

    public void RegistarNumeroCartoesVermelhos()
    {
        numeroCartoesVermelhos++;
    }

    public bool VerificarVinculoClube()
    {
        return !string.IsNullOrEmpty(clube);
    }

    public string Imprimir()
    {
        return "\nNome: " + this.nome + "\nIdade" + this.idade + "\nPosição: " + this.posicao + "\nClube: " + this.clube + "\nNúmero de Gols: " + this.numeroGols + "\nNúmero de Assistências: " + this.numeroAssistencias + "\nNúmero de Cartões Amarelos: " + this.numeroCartoesAmarelos + "\nNúmero de Cartões Vermelhos: " + this.numeroCartoesVermelhos;
    }
}
