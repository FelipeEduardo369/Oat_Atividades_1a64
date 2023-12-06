using System;

namespace Oat_Atividades_1a64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int verificador2 = 1;
            while (verificador2 == 1)
            {
                Console.Clear();   
                Console.WriteLine("Bem vindo ao menu, escolha a atividade *de 1 a 64*");
                int verificador = int.Parse(Console.ReadLine());

                while (verificador < 1 || verificador > 64)
                {
                    Console.WriteLine("Fora do interavalo, digite novamente");
                    verificador = int.Parse(Console.ReadLine());

                }
                switch (verificador)
                {
                    case 1:
                        {
                            Atividade001 Atividade01 = new Atividade001();
                            Atividade01.Atividade01();
                            break;
                        }
                    case 2:
                        {
                            Atividade002 Atividade02 = new Atividade002();
                            Atividade02.Atividade02();
                            break;
                        }
                    case 3:
                        {
                            Atividade003 Atividade03 = new Atividade003();
                            Atividade03.Atividade03();
                            break;
                        }
                    case 4:
                        {
                            Atividade004 Atividade04 = new Atividade004();
                            Atividade04.Atividade04();
                            break;
                        }
                    case 5:
                        {
                            Atividade005 Atividade05 = new Atividade005();
                            Atividade05.Atividade05();
                            break;
                        }
                    case 6:
                        {
                            Atividade006 Atividade06 = new Atividade006();
                            Atividade06.Atividade06();
                            break;
                        }
                    case 7:
                        {
                            Atividade007 Atividade07 = new Atividade007();
                            Atividade07.Atividade07();
                            break;
                        }
                    case 8:
                        {
                            Atividade008 Atividade08 = new Atividade008();
                            Atividade08.Atividade08();
                            break;
                        }
                    case 9:
                        {
                            Atividade009 Atividade09 = new Atividade009();
                            Atividade09.Atividade09();
                            break;
                        }
                    case 10:
                        {
                            Atividade010 Atividade10 = new Atividade010();
                            Atividade10.Atividade10();
                            break;
                        }
                    case 11:
                        {
                            Atividade011 Atividade11 = new Atividade011();
                            Atividade11.Atividade11();
                            break;
                        }
                    case 12:
                        {
                            Atividade012 Atividade12 = new Atividade012();
                            Atividade12.Atividade12();
                            break;
                        }
                    case 13:
                        {
                            Atividade013 Atividade13 = new Atividade013();
                            Atividade13.Atividade13();
                            break;
                        }
                    case 14:
                        {
                            Atividade014 Atividade14 = new Atividade014();
                            Atividade14.Atividade14();
                            break;
                        }
                    case 15:
                        {
                            Atividade015 Atividade15 = new Atividade015();
                            Atividade15.Atividade15();
                            break;
                        }
                    case 16:
                        {
                            Atividade016 atividade16 = new Atividade016();
                            atividade16.Atividade16();
                            break;
                        }
                    case 17: 
                        { 
                            Atividade017 Atividade17 = new Atividade017();
                            Atividade17.Atividade17();
                            break;
                        }
                    case 18:
                        {
                            Atividade018 atividade18 = new Atividade018();
                            atividade18.Atividade18();
                            break;
                        }
                    case 19: 
                        {
                            Atividade019 Atividade19 = new Atividade019();
                            Atividade19.Atividade19();
                            break;
                        }
                    case 20:
                        {
                            Atividade020 Atividade20 = new Atividade020();
                            Atividade20.Atividade20();
                            break;
                        }
                    case 21:
                        {
                            Atividade021 Atividade21 = new Atividade021();
                            Atividade21.Atividade21();
                            break;
                        }
                    case 22:
                        {
                            Atividade022 Atividade22 = new Atividade022();
                            Atividade22.Atividade22();
                            break;
                        }
                    case 23:
                        {
                            Atividade023 Atividade23 = new Atividade023();
                            Atividade23.Atividade23();
                            break;
                        }
                    case 24: 
                        {
                            Atividade024 Atividade24 = new Atividade024();
                            Atividade24.Atividade24();
                            break;
                        }
                    case 25:
                        {
                            Atividade025 atividade25 = new Atividade025();
                            atividade25.Atividade25();
                            break;
                        }
                    case 26:
                        {
                            Atividade026 Atividade26 = new Atividade026();
                            Atividade26.Atividade26();
                            break;
                        }
                    case 27:
                        {
                            Atividade027 Atividade27 = new Atividade027();
                            Atividade27.Atividade27();
                            break;
                        }
                    case 28:
                        {
                            Atividade028 Atividade28 = new Atividade028();
                            Atividade28.Atividade28();
                            break;
                        }
                    case 29:
                        {
                            Atividade029 Atividade29 = new Atividade029();
                            Atividade29.Atividade29();
                            break;
                        }
                    case 30:
                        {
                            Atividade030 Atividade30 = new Atividade030();
                            Atividade30.Atividade30();
                            break;
                        }
                    case 31:
                        {
                            Atividade031 Atividade31 = new Atividade031();
                            Atividade31.Atividade31();  
                            break;
                        }
                    case 32:
                        {
                            Atividade032 Atividade32 = new Atividade032();
                            Atividade32.Atividade32();
                            break;
                        }
                    case 33:
                        {
                            Atividade033 Atividade33 = new Atividade033();
                            Atividade33.Atividade33();
                            break;
                        }
                    case 34:
                        {
                            Atividade034 Atividade34 = new Atividade034();
                            Atividade34.Atividade34();
                            break;
                        }
                    case 35:
                        {
                            Atividade035 Atividade35 = new Atividade035();
                            Atividade35.Atividade35();
                            break;
                        }
                    case 36:
                        {
                            Atividade036 Atividade36 = new Atividade036();
                            Atividade36.Atividade36();
                            break;
                        }
                    case 37:
                        {
                            Atividade037 Atividade37 = new Atividade037();
                            Atividade37.Atividade37();
                            break;
                        }
                    case 38:
                        {
                            Atividade038 Atividade38 = new Atividade038();
                            Atividade38.Atividade38();
                            break;
                        }
                    case 39:
                        {
                            Atividade039 Atividade39 = new Atividade039();
                            Atividade39.Atividade39();
                            break;
                        }
                    case 40:
                        {
                            Atividade040 Atividade40 = new Atividade040();  
                            Atividade40.Atividade40();
                            break;

                        }
                    case 41:
                        {
                            Atividade041 Atividade41 = new Atividade041();
                            Atividade41.Atividade41();
                            break;
                        }
                    case 42:
                        {
                            Atividade042 Atividade42 = new Atividade042();  
                            Atividade42.Atividade42();
                            break;
                        }
                    case 43:
                        {
                            Atividade043 Atividade43 = new Atividade043();
                            Atividade43.Atividade43();
                            break;
                        }
                    case 44:
                        {
                            Atividade044 Atividade44 = new Atividade044();
                            Atividade44.Atividade44();
                            break;
                        }
                    case 45:
                        {
                            Atividade045 Atividade45 = new Atividade045();
                            Atividade45.Atividade45();
                            break;
                        }
                    case 46:
                        {
                            Atividade046 Atividade46 = new Atividade046();
                            Atividade46.Atividade46();
                            break;
                        }
                    case 47:
                        {
                            Atividade047 Atividade47 = new Atividade047();
                            Atividade47.Atividade47();
                            break;
                        }
                    case 48:
                        {
                            Atividade048 Atividade48 = new Atividade048();
                            Atividade48.Atividade48();
                            break;
                        }
                    case 49:
                        {
                            Atividade049 Atividade49 = new Atividade049();
                            Atividade49.Atividade49();
                            break;
                        }
                    case 50: 
                        {
                            Atividade050 Atividade50 = new Atividade050();
                            Atividade50.Atividade50();
                            break;
                        }
                    case 51:
                        {
                            Atividade051 Atividade51 = new Atividade051();
                            Atividade51.Atividade51();
                            break;
                        }
                    case 52:
                        {
                            Atividade052 atividade52 = new Atividade052();
                            atividade52.Atividade52();
                            break;
                        }
                    case 53:
                        {
                            Atividade053 Atividade53 = new Atividade053();
                            Atividade53.Atividade53();
                            break;
                        }
                    case 54:
                        {
                            Atividade054 Atividade54 = new Atividade054();
                            Atividade54.Atividade54();
                            break;
                        }
                    case 55:
                        {
                            Atividade055 Atividade55 = new Atividade055();
                            Atividade55.Atividade55();
                            break;
                        }
                    case 56:
                        {
                            Atividade056 Atividade56 = new Atividade056();  
                            Atividade56.Atividade56();
                            break;
                        }
                    case 57:
                        {
                            Atividade057 Atividade57 = new Atividade057();
                            Atividade57.Atividade57();
                            break;
                        }
                    case 58:
                        {
                            Atividade058 Atividade58 = new Atividade058();
                            Atividade58.Atividade58();
                            break;
                        }
                    case 59:
                        {
                            Atividade059 Atividade59 = new Atividade059();
                            Atividade59.Atividade59();
                            break;
                        }
                    case 60:
                        {
                            Atividade060 Atividade60 = new Atividade060();
                            Atividade60.Atividade60();
                            break;
                        }
                    case 61:
                        {
                            Atividade061 Atividade61 = new Atividade061();  
                            Atividade61.Atividade61();
                            break;
                        }
                    case 62:
                        {
                            Atividade062 Atividade62 = new Atividade062();  
                            Atividade62.Atividade62();
                            break;
                        }
                    case 63:
                        {
                            Atividade063 Atividade63 = new Atividade063();
                            Atividade63.Atividade63();
                            break;
                        }
                    case 64:
                        {
                            Atividade064 Atividade64 = new Atividade064();
                            Atividade64.Atividade64();
                            break;
                        }
                }   
                Console.WriteLine("Digite 1 para voltar ao menu, qualquer outro número para sair");
                verificador2 = int.Parse(Console.ReadLine());

            }
            
        }
    }
}
