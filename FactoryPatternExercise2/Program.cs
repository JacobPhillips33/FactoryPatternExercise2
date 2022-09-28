using FactoryPatternExercise2;

IDataAccess newDataAccess = DataAccessFactory.BuildDatabase();
newDataAccess.AccessDatabase();
