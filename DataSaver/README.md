# Data saver
Um utilitário simples para salvar e recuprar dados serializados.


## Como usar

### Salvando dados
Primeiro crie uma classe serializável com os dados que deseja salvar:

![image](https://user-images.githubusercontent.com/53667441/180339185-8f0b0ac1-ce20-4e0c-8e82-544af8642546.png)

No seu script, crie uma instância desta classe e a inicialize com os valores desejados:

![image](https://user-images.githubusercontent.com/53667441/180339267-dba3c452-6407-41ec-a061-b0f26b03494f.png)

E então chame a função estática "SaveData" da classe "SaveSerial" passando o objeto e o nome do arquivo que será salvo:

![image](https://user-images.githubusercontent.com/53667441/180338714-22d87140-394d-4aeb-aef0-9978cac18bcd.png)

### Carregando dados
Para carregar seu arquivo serializado, crie uma instância da classe serializada e chame a função estática "LoadData" da classe "SaveSerial" passando o mesmo nome do arquivo salvo.

![image](https://user-images.githubusercontent.com/53667441/180339060-c9e21955-a0e8-4da4-864a-c873c167ac77.png)

Aproveite :)


