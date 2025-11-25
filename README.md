# City Manager 🏙️  
סימולטור ניהול עיר למחשב  

ב-City Manager אתה משחק בתור ראש עיר המנהל עיר מתפתחת.  
המטרה שלך היא לבנות ולשדרג מבנים, לאזן בין שמחה, תקציב ואוכלוסייה, להתמודד עם אירועים אקראיים ולקבל החלטות ניהוליות חכמות.  
המשחק משלב אסטרטגיה ולמידה חווייתית עם חוויה מהנה של בניית עיר משגשגת.  

🎮 פלטפורמה: נייד (טלפון)  
👤 שחקן יחיד  
🏢 סוג המשחק: סימולציה / ניהול עיר  

יוצרים: שגיא חסיד ורונן צ'רשניה

[formal elements](https://github.com/Ronen-Sagi/City-Manager/blob/main/formal%20elements.md)

[itch.io](https://rs-co.itch.io/city-manager)


    +---------------------+
    |   ResourceManager   |
    +---------------------+
    | - money : int       |
    | - OnMoneyChanged    |
    +---------------------+
    | + Money : int       |
    | + AddMoney(int)     |
    | + SpendMoney(int)  |
    +---------------------+

           ▲
           |
    +---------------------------+
    |    MoneyUI               |
    +---------------------------+
    | - moneyText : TMP_Text   |
    +---------------------------+
    | + Start()                |
    | - UpdateUI(int)          |
    | + OnDestroy()            |
    +---------------------------+


    +---------------------------+
    |        Building           |
    +---------------------------+
    | - cost : int             |
    | - level : int            |
    | - nameTag : TMP          |
    | - levelTag : TMP         |
    +---------------------------+
    | + Cost : int             |
    | + ActivateBuilding()     |
    | - LevelUp()              |
    | + Start()                |
    +---------------------------+


                 +------------------------------+
                 |  BuildingButtonsScript       |
                 +------------------------------+
                 | - cityHall : GameObject      |
                 | - school : GameObject        |
                 | - hospital : GameObject      |
                 | - b : Building               |
                 +------------------------------+
                 | + BuildCityHall()            |
                 | + BuildSchool()              |
                 | + BuildHospital()            |
                 | + Build()                    |
                 +------------------------------+
