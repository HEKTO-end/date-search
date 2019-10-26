
namespace DataWsego
{
    public class Proverka
    {
        public static string Zodiac_Sign(int year, int month, int day)
        {
            if ((day >= 21 && month == 3) || (day <= 20 && month == 4)) return "Овен";
            if ((day >= 21 && month == 4) || (day <= 20 && month == 5)) return "Телец";
            if ((day >= 21 && month == 5) || (day <= 21 && month == 6)) return "Близнецы";
            if ((day >= 22 && month == 6) || (day <= 22 && month == 7)) return "рак";
            if ((day >= 23 && month == 7) || (day <= 23 && month == 8)) return "лев";
            if ((day >= 24 && month == 8) || (day <= 23 && month == 9)) return "дева";
            if ((day >= 24 && month == 9) || (day <= 23 && month == 10)) return "весы";
            if ((day >= 24 && month == 10) || (day <= 22 && month == 11)) return "скорпион";
            if ((day >= 23 && month == 11) || (day <= 21 && month == 12)) return "стрелец";
            if ((day >= 22 && month == 12) || (day <= 20 && month == 1)) return "козерог";
            if ((day >= 21 && month == 1) || (day <= 18 && month == 2)) return "водолей";
            else return "рыбы";
        }
        public static string Chinese_Сalendar(int year, int month, int day)
        {
            if (year % 4 != 0)
            {
                switch (year % 12)
                {
                    case 1: return "курицы";
                    case 2: return "собаки";
                    case 3: return "свиньи";
                    case 4: return "мыши";
                    case 5: return "коровы";
                    case 6: return "тигра";
                    case 7: return "заяца";
                    case 8: return "улитки";
                    case 9: return "змеи";
                    case 10: return "лошади";
                    case 11: return "овцы";
                    case 12: return "обезьяны";
                }
                return "Вы метрвы";
            }
            else
            {
                switch (year % 2 + 11)
                {
                    case 0: return "курицы \n и ваш год к томуже високостный";
                    case 1: return "собаки \n и ваш год к томуже високостный";
                    case 2: return "свиньи \n и ваш год к томуже високостный";
                    case 3: return "мыши \n и ваш год к томуже високостный";
                    case 4: return "коровы \n и ваш год к томуже високостный";
                    case 5: return "тигра \n и ваш год к томуже високостный";
                    case 6: return "заяца \n и ваш год к томуже високостный";
                    case 7: return "улитки \n и ваш год к томуже високостный";
                    case 8: return "змеи \n и ваш год к томуже високостный";
                    case 9: return "лошади \n и ваш год к томуже високостный";
                    case 10: return "овцы \n и ваш год к томуже високостный";
                    case 11: return "обезьяны \n и ваш год к томуже високостный";
                }
                return "Вы метрвы! \n Зато ваш год был високостным";
            }
        }
    }
}
