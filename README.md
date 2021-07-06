# .Net 5
*Это моя история в изучении C# .Net5. За это лето 20 июня 2021 - 31 августа 2021 я
буду выкладывать историю своих успехов в изучении. Полная информация находится в файле README.md*

# Старт
* В первые дни изучения **С#** я выучил, как создавать **.net** проект через консоль
для этого я использовал команды:
<br><code>dotnet new console</code> - для создания проекта и <code>dotnet run</code> - для запуска проекта. 
По умолчанию на консоль выводится сообщение <code>Hello World!</code>
* Из нового:
* - безопасные преобразования типов
* - ключевое слово <code>checked</code>
* - все возможные виды массивов(например зубчатый массив)
* - ключевое слово <code>params</code> и его использование
* - кортежи и их использование
* - **null операторы** 
* - индексаторы


Ссылка на мои конспекты [здесь](https://trello.com/net585)
<br><br>

---
# 07/06/2021

Сегодня вышел новый коммит, я добавил не все папки, а лишь те, которые содержат в себе код

<br>В пятой теме говориться об операторах <code>implicit/explicit</code>
<br>Explicit - явное преобразование

```csharp
public static explicit operator int(Counter counter)
{
     return counter.Seconds;<br>
}
```

<br>Implicit - неявное преобразование

```csharp
public static implicit operator Counter(int x)
{
     return new Counter { Seconds = x };
}
```

Используются для преобразования типов, как например:

```csharp
//implicit
int val = 10;
double val2 = val;

//explicit
int val = 10;
short val2 = (short) val;
```
