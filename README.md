#**Кој сака да биде милионер ?**

<p align="center">
  <img src="http://zase.mk/wp-content/uploads/2013/11/Logo_of_Milioner.jpg">
</p>

Проектна задача по визуелно програмирање <br>
  Изработија: <br>
    - [**Давид Симеоновски**](https://github.com/Dekacc) <br>
    - [**Никола Танев**](https://github.com/tanevnik)
    
  ---
 
 
##1. Вовед

<b>„Кој сака да биде милионер ?“</b> е интернационо и едно од најпознатите квиз ТВ шоуа во светот на кое натпреварувачите одговараат на најразлични прашања и целат кон освојување на милионската награда <b>$$$</b>. <br>
По пример од овој квиз, развиени се компјутерски, мобилни и веб апликации кои нудат забава, опуштање и проверување на знаењето од пространи теми.
<br>



##2. Начин на игра и правила

###2.1 Правила
Начинот на играње и правилата на овој квиз на сите ни се многу добро познати. <br> 
Играта се состои од 15 прашања со три загарантирани суми на 5-тото од 5.000ден и 10-тото прашање од 125.000ден и главната награда на 15-тото прашање од <b>4 МИЛИОНИ ДЕНАРИ</b>. <br>
Натпреварувачот одговара на секое прашање кое има по 4 понудени одговори од кои само еден е точен. За секој точен одговор, натпреварувачот ја добива сумата која ја носи прашањето и се искачува ниво повисоко до целта на 15-тото прашање. Доколку наптреварувачот одговори неточно на поставеното прашање, тој ја завршува играта и ја заработува последната загарантирана сума. Натпреварувачот има можност да се откаже од понатамошно играње и да замине со сумата која дотогаш ја има освоено.<br>

[50/50]: https://github.com/tanevnik/remote-repo/tree/master/DocumentImages/ff.png "50/50"
[callFriend]: https://github.com/adam-p/markdown-here/raw/master/src/common/images/icon48.png "Повикај пријател"
[askAudience]: https://github.com/adam-p/markdown-here/raw/master/src/common/images/icon48.png "Прашај ја публиката"
[change]: https://github.com/adam-p/markdown-here/raw/master/src/common/images/icon48.png "Замени прашање"

По пат може да ни помогнат 4 џокери:
* ![ff](https://github.com/tanevnik/Millionaire/blob/develop/Millionaire/Resources/_5050.png?raw=true "50/50") <br> <b>50/50</b> - системот отстранува 2 неточни одговори <br> <br>
* ![cf](https://github.com/tanevnik/Millionaire/blob/develop/Millionaire/Resources/phone.png?raw=true "50/50") <br> <b>Повикај пријател</b> - добивате 30 секунди телефонски повик на некој ваш познаник да ви помогне за прашањето <br> <br>
* ![au](https://github.com/tanevnik/Millionaire/blob/develop/Millionaire/Resources/audience.png?raw=true "Прашај ја публиката") <br> <b>Прашај ја публиката</b> - публиката со гласање се изјаснува за точниот одговор на прашањето <br> <br> 
* ![cq](https://github.com/tanevnik/Millionaire/blob/develop/Millionaire/Resources/_switch.png?raw=true "Промени прашање") <br> <b>Замени прашање</b> - замена на тековното прашање со ново прашање <br> 

###2.2 Нова игра
Новата игра се започнува едноставно со кликнување на копчето од главното мени за нова игра со почеток од прво прашање и овозможени сите 4 џокери.

![home](https://github.com/tanevnik/Millionaire/blob/develop/DocumentationImages/homeScreen.png?raw=true)  |  ![mane](https://github.com/tanevnik/Millionaire/blob/develop/DocumentationImages/mainScreen.png?raw=true)
:-------------------------:|:-------------------------:


###2.3 Одговарање на прашање
На прашањата се одговара едноставно со кликнување на еден од четирите понудени одговори и при тоа потребно е да се потврди дека тоа е конечниот одговор.

![home](https://github.com/tanevnik/Millionaire/blob/develop/DocumentationImages/selectAnswere.png?raw=true)


###2.4 Користење на џокери
Кога натпреварувачот е во ситуација да не го знае одговорот на прашањето, на располагање му се 4 џокери кои му нудат потенцијална помош за точно оговарање на прашањето.

50/50                      |  Прашај ја публиката
:-------------------------:|:-------------------------:
![home](https://github.com/tanevnik/Millionaire/blob/develop/DocumentationImages/fiftyFifty.png?raw=true)  |  ![mane](https://github.com/tanevnik/Millionaire/blob/develop/DocumentationImages/audiance.png?raw=true)
Системот на случаен начин отстранува 2 неточни одговори и остануваат само еден точен и еден неточен одговор | Публиката преку систем на гласање се изјаснува за тоа кој одговор смета дека е точен и резултатите му се прикажуваат на натпреварувачот

Повикај пријател           |  Промени прашање
:-------------------------:|:-------------------------:
![call](https://github.com/tanevnik/Millionaire/blob/develop/DocumentationImages/friend.png?raw=true)  |  ![switch](https://github.com/tanevnik/Millionaire/blob/develop/DocumentationImages/change.png?raw=true)
Натпреварувачот добива телефонско јавување на било кој познаник да му го постави тековното прашање и да побара помош од него | Тековното прашање се заменува со ново прашање

###2.5 Откажување
Во случај кога натпреварувачот не сака да оговара на даденото прашање, има можност да се откаже од играта и да си замине со дотогаш освоената сума на пари

![serender](https://github.com/tanevnik/Millionaire/blob/develop/DocumentationImages/serender1.png?raw=true)

Натпреварувачот треба да ја потврди негоавата одлука како конечна и да заврши со играта !

![serender](https://github.com/tanevnik/Millionaire/blob/develop/DocumentationImages/serender2.png?raw=true)



##3. Архитектура

###Податочни структури, класи, база на прашања ....

Објаснување за:
* приказ на прашања
* одговарање на прашање
* транзиција и приказ низ скалите за пари
* користење на мултимедија (опционално)
* БАРЕМ ЗА ЕДНА ОД ОВИЕ ДА СЕ ОПИШЕ ФУНКЦИОНАЛНОСТА И ДА СЕ ПРИКАЖЕ КОД




  
