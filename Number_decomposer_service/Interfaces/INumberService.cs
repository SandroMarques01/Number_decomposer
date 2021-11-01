using System.Collections.Generic;

namespace Number_decomposer_service.Interfaces
{
    public interface INumberService
    {
        List<List<int>> GetTechnicalChallenge(int numero);
    }
}
