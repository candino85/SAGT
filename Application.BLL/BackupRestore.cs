using Application.DLL;

namespace Application.BLL
{
    public sealed class BackupRestore
    {
        BackupRestoreRepository _repository = new BackupRestoreRepository();

        public string BackupDatabase(string path)
        {
            return _repository.BackupDatabase(path);
        }
        public string RestoreDatabase(string path)
        {
            return _repository.RestoreDatabase(path);
        }
    }
}
