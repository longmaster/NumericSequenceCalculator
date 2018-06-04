using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NibApi.Core
{
    public interface INumberSequence
    {
        Task<IEnumerable<int>> GetAllNumber(int value);

        Task<IEnumerable<int>> GetEvenNumber(int value);

        Task<IEnumerable<int>> GetOddNumber(int value);

        Task<string> GetAllNumberCharacter(int value);

    }
}
