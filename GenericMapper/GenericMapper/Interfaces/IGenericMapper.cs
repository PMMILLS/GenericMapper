namespace GenericMapper.Interfaces
{
    interface IGenericMapper
    {
        R Map<T, R>(T t);
    }
}
