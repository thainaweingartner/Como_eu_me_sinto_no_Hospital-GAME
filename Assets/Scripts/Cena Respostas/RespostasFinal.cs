using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RespostasFinal : MonoBehaviour
{
    string nome = Confirmar_Nome.nomePlayer;
    string[] respostas = { Botao1.resposta1,
                    Botao2.resposta2,
                    Botao3.resposta3,
                    Botao4.resposta4,
                    Botao5.resposta5,
                    botao6.resposta6,
                    Botao7.resposta7,
                    Botao8.resposta8,
                    Botao9.resposta9,
                    Botao10.resposta10,
                    Botao11.resposta11};
    string perguntaextra = Casa12.perguntaExtra;
    string respostaextra = Casa12.respostaExtra;
    void Update()
    {
        GetComponent<Text>().text = "Nome: " + nome +
                                "\n\nResposta 1: "+respostas[0]+
                                 "\n\nResposta 2: "+respostas[1]+
                                 "\n\nResposta 3: " + respostas[2]+
                                 "\n\nResposta 4: " + respostas[3]+
                                 "\n\nResposta 5: " + respostas[4]+
                                 "\n\nResposta 6: " + respostas[5]+
                                 "\n\nResposta 7: " + respostas[6]+
                                 "\n\nResposta 8: " + respostas[7]+
                                 "\n\nResposta 9: " + respostas[8]+
                                 "\n\nResposta 10: " + respostas[9]+
                                 "\n\nResposta 11: " + respostas[10]+
                                 "\n\n" + perguntaextra +  ": " + respostaextra;
    }
}
