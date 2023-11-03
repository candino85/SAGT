namespace Application.BLL
{
    public class Muestra
    {
        DLL.mapper_Muestra mapper_Muestra = new DLL.mapper_Muestra();

        public bool Create(BE.Muestra muestra)
        {
            return mapper_Muestra.Create(muestra);
        }
    }
}