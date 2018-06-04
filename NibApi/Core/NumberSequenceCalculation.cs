using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NibApi.Core
{
    public class NumberSequenceCalculation:INumberSequence
    {
        //All numbers up to and including the number entered
        public async Task<IEnumerable<int>> GetAllNumber(int value) =>  await Task.FromResult(Enumerable.Range(0, value + 1));

        //All even numbers up to and including the number entered
        public async Task<IEnumerable<int>> GetEvenNumber(int value) => await Task.FromResult(Enumerable.Range(0, value + 1).Where(x => x % 2 == 0));

        //All odd numbers up to and including the number entered
        public async Task<IEnumerable<int>> GetOddNumber(int value) => await Task.FromResult(Enumerable.Range(0, value + 1).Where(x => x % 2 > 0));

        /*
         All numbers up to and including the number entered,
            except when a number is a multiple of 3 output C,
                   and when a number is a multiple of 5 output E,
                   and when a number is a multiple of both 3 and 5 output Z
         */
        public async Task<string> GetAllNumberCharacter(int value)
        {
            if (value % 15 == 0)
                return await Task.FromResult<string>("Z");
            if (value % 3 == 0)
                return await Task.FromResult<string>("C");
            if (value % 5 == 0)
                return await Task.FromResult<string>("E");

            return null;
        }

    }
}
