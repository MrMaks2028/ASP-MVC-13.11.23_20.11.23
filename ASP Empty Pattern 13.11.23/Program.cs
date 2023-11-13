namespace ASP_Empty_Pattern_13._11._23
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            // ������������� ��������� � �������������
            // �������� - name � ������: ���������� / ����� ����������� / �������������� ��������
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
             );
            

            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}