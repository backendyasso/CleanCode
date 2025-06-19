public static class Router
{
    public const string root = "api";
    public const string version = "v1";
    public const string concat = root + "/" + version + "/";

    public static class studentRouting
    {
        public const string Prefix = concat + "student";
        public const string List = "";
        public const string GetById = "{id}";
        public const string Create = "create";
        public const string Update = "update";
        public const string Delete = "delete/{id}";
    }

    public static class departmentRouting
    {
        public const string Prefix = concat + "department";
        public const string List = "";
        public const string GetById = "{id}";
        public const string Create = "create";
        public const string Update = "update";
        public const string Delete = "delete/{id}";
    }

    public static class subjectRouting
    {
        public const string Prefix = concat + "subject";
        public const string List = "";
        public const string GetById = "{id}";
        public const string Create = "create";
        public const string Update = "update";
        public const string Delete = "delete/{id}";
    }
}
