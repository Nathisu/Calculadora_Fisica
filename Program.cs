using System;

namespace Física
{
    class program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Selecione a matéria\n1 - Movimento Retilíno Uniforme\n2 - Movimento Circular\n");
            int selecao = int.Parse(Console.ReadLine());

            if (selecao < 1 || selecao > 5)
            {
                Console.WriteLine("{0} não é uma escolha válida", selecao);
                Menu();
            }

            switch (selecao)
            {
                case 1:
                    Console.Clear();
                    MRU();
                    break;

                case 2:
                    Console.Clear();
                    MCU();
                    break;
            }
        }

        static void MRU()
        {
            Console.WriteLine("Selecione a fórmula\n1 - Velocidade Média\n2 - Aceleração Média\n3 - Função Horária da Posição\n4 - Função Horária da Velocidade\n");
            int selecao = int.Parse(Console.ReadLine());
            Console.Clear();

            if (selecao < 1 || selecao > 4)
            {
                Console.WriteLine("{0} não é uma escolha válida", selecao);
                MRU();
            }

            switch (selecao)
            {
                case 1:
                    VelocidadeMedia();
                    break;
                case 2:
                    AceleracaoMedia();
                    break;
                case 3:
                    FuncaoHorariadaPosicao();
                    break;
                case 4:
                    FuncaoHorariadaVelocidade();
                    break;
            }
        }

        static void MCU()
        {
            Console.WriteLine("Selecione a fórmula\n1 - Velocidade Física\n2 - Velocidade Angular\n3 - \n4 - \n");
            int selecao = int.Parse(Console.ReadLine());
            Console.Clear();

            /*if (selecao < 1 || selecao > 2)
            {
                Console.WriteLine("{0} não é uma escolha válida", selecao);
                MRU();
            }*/

            switch (selecao)
            {
                case 1:
                    VelocidadeFisica();
                    break;
                case 2:
                    VelocidadeAngular();
                    break;
            }
        }

        static void VelocidadeMedia()
        {
            Console.WriteLine("Insira a variação do deslocamento");
            double DeltaS = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a variação do tempo");
            double DeltaT = double.Parse(Console.ReadLine());
            Console.Clear();
            double VM = DeltaS / DeltaT;
            Console.WriteLine("VM({0}) = DeltaS({1})/DeltaT({2})\nA velocidade média é: {3} m/s\n\n1 - Repetir\n2 - Voltar\n3 - Fechar", VM, DeltaS, DeltaT, VM);
            int selecao = int.Parse(Console.ReadLine());

            switch (selecao)
            {
                case 1:
                    Console.Clear();
                    VelocidadeMedia();
                    break;
                case 2:
                    Console.Clear();
                    MCU();
                    break;
                case 3:
                    break;
            }
        }

        static void AceleracaoMedia()
        {
            Console.WriteLine("Insira a variação da velocidade");
            double DeltaV = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a variação do tempo");
            double DeltaT = double.Parse(Console.ReadLine());
            Console.Clear();
            double AM = DeltaV / DeltaT;
            Console.WriteLine("AM({0}) = DeltaV({1})/DeltaT({2})\nA aceleração média é: {3} m/s²\n\n1 - Repetir\n2 - Voltar\n3 - Fechar", AM, DeltaV, DeltaT, AM);
            int selecao = int.Parse(Console.ReadLine());

            switch (selecao)
            {
                case 1:
                    Console.Clear();
                    AceleracaoMedia();
                    break;
                case 2:
                    Console.Clear();
                    MCU();
                    break;
                case 3:
                    break;
            }
        }

        static void FuncaoHorariadaPosicao()
        {
            Console.WriteLine("Insira a posição inicial");
            double Si = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a velocidade");
            double V = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o tempo");
            double T = double.Parse(Console.ReadLine());
            Console.Clear();
            double Sf = Si + (V * T);
            Console.WriteLine("Sf({0}) = Si({1})+(V({2})*T({3}))\nA posição final é: {4} m\n\n1 - Repetir\n2 - Voltar\n3 - Fechar", Sf,Si,V,T,Sf);
            int selecao = int.Parse(Console.ReadLine());

            switch (selecao)
            {
                case 1:
                    Console.Clear();
                    FuncaoHorariadaPosicao();
                    break;
                case 2:
                    Console.Clear();
                    MCU();
                    break;
                case 3:
                    break;
            }
        }

        static void FuncaoHorariadaVelocidade()
        {
            Console.WriteLine("Insira a velocidade inicial");
            double Vi = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a aceleração");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o tempo");
            double T = double.Parse(Console.ReadLine());
            Console.Clear();
            double Vf = Vi + (A * T);
            Console.WriteLine("Vf({0}) = Vi({1})+(A({2})*T({3}))\nA velocidade final é: {4} m/s\n\n1 - Repetir\n2 - Voltar\n3 - Fechar", Vf,Vi,A,T,Vf);
            int selecao = int.Parse(Console.ReadLine());

            switch (selecao)
            {
                case 1:
                    Console.Clear();
                    FuncaoHorariadaVelocidade();
                    break;
                case 2:
                    Console.Clear();
                    MCU();
                    break;
                case 3:
                    break;
            }
        }

        static void VelocidadeFisica()
        {
            Console.WriteLine("Insira o raio da circuferência");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a variação do deslocamento angular");
            double DeltaO = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a variação do tempo");
            double DeltaT = double.Parse(Console.ReadLine());
            Console.Clear();
            double VF = (r*DeltaO) / DeltaT;
            Console.WriteLine("VF({0}) = (r({1})*DeltaO({2}))/DeltaT({3})\nA velocidade física é: {4} m/s\n\n1 - Repetir\n2 - Voltar\n3 - Fechar", VF, r, DeltaO, DeltaT, VF);
            int selecao = int.Parse(Console.ReadLine());

            switch (selecao)
            {
                case 1:
                    Console.Clear();
                    VelocidadeFisica();
                    break;
                case 2:
                    Console.Clear();
                    MRU();
                    break;
                case 3:
                    break;
            }
        }

        static void VelocidadeAngular()
        {
            Console.WriteLine("Insira a variação do deslocamento angular");
            double DeltaO = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a variação do tempo");
            double DeltaT = double.Parse(Console.ReadLine());
            Console.Clear();
            double w = DeltaO / DeltaT;
            Console.WriteLine("w({0}) = DeltaO({1})/DeltaT({2})\nA velocidade angular é: {3} rad/s\n\n1 - Repetir\n2 - Voltar\n3 - Fechar", w, DeltaO, DeltaT, w);
            int selecao = int.Parse(Console.ReadLine());

            switch (selecao)
            {
                case 1:
                    Console.Clear();
                    VelocidadeAngular();
                    break;
                case 2:
                    Console.Clear();
                    MRU();
                    break;
                case 3:
                    break;
            }
        }
    }
}