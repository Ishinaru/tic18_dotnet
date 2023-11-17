# 1. Configuração do Ambiente:
## Problema: Como você pode verificar se o .NET SDK está corretamente instalado emseu sistema? Em um arquivo de texto ou Markdown, liste os comandos que podemser usados para verificar a(s) versão(ões) do .NET SDK instalada(s), como remover e atualizar.

Para verificar se o .NET SDK está corretamente instalado pode-se usar o comando:
dotnet --version
para verificar versão atual do .NET SDK instalada no sistema.

Para remover:
dotnet --uninstall-sdk <versão>
para remover uma versão específica do .NET SDK.

Para atualizar:
dotnet --version
para verificar e atualizar o .NET SDK para a versão mais recente disponível.


# 2. Tipos de Dados:
## Problema: Quais são os tipos de dados numéricos inteiros disponíveis no .NET? Dê exemplos de uso para cada um deles através de exemplos.
Os inteiros disponíveis são:

int: que representa números inteiros com sinal de 32 bits.

long: que representa números inteiros com sinal de 64 bits.

short: que representa números inteiros com sinal de 16 bits.

byte: que representa números inteiros sem sinal de 8 bits.

sbyte: que representa números inteiros com sinal de 8 bits.

uint: que representa números inteiros sem sinal de 32 bits.

ulong: que representa números inteiros sem sinal de 64 bits.

exemplo de código:

~~~c#
    int inteiro = int.MaxValue;
    short intShort = short.MaxValue;
    long intLong = long.MaxValue;
    byte intByte = byte.MaxValue;
    sbyte intSbyte = sbyte.MaxValue;
    uint intUint = uint.MaxValue;
    ulong intUlong = ulong.MaxValue;
    ushort intUshort = ushort.MaxValue;

    Console.WriteLine("Inteiro = "+inteiro);
    Console.WriteLine("Short = "+intShort);
    Console.WriteLine("Long = "+intLong);
    Console.WriteLine("Byte = "+intByte);
    Console.WriteLine("Sbyte = "+intSbyte);
    Console.WriteLine("Uint = "+intUint);
    Console.WriteLine("Ulong = "+intUlong);
    Console.WriteLine("Ushort = "+intUshort);
~~~