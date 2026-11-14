using SA.APILibrary.DTOs;

namespace SA.APILibrary.Services
{
    public interface IServiceHash
    {
        ResultHashDTO Hash(string input);
        ResultHashDTO Hash(string input, byte[] salt);
    }
}