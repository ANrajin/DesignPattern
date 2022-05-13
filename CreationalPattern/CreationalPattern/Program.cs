using CreationalPattern.Singleton;

Logger fromFather = Logger.GetLogger();
fromFather.Write("Father instantiated");

Logger fromMother = Logger.GetLogger();
fromMother.Write("Mother instantiated");
