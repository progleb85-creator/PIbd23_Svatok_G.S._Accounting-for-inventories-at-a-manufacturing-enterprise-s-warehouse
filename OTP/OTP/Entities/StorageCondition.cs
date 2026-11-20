namespace OTP.Entities;

[Flags]
public enum StorageCondition
{
    //Не заданы
    None = 0,

    //Сухое помещение
    Dry = 1,

    //Отапливаемое помещение
    Heated = 2,

    //Вентиляция
    Ventilated = 4,

    //"Пожаробезопасное хранение
    FireSafe = 8
}