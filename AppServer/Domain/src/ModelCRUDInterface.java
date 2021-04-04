public interface ModelCRUDInterface {
    default void Create(String className)
    {
        //Do some create class object related SQL shit.
    }
    default void Delete(String className, int id)
    {
        //Do some delete obj in base shit.
    }
    default  void Edit(String className, int recordID)
    {
        //Do some edit related shit.
    }


}
