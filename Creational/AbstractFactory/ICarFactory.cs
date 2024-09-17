

namespace AbstractFactory
{
    //اینتر فیس کارخانه انتزاعی
    internal interface ICarFactory
    {
        ISedan CreateSedan();
        ISUV CreateSUV();
    }
}
