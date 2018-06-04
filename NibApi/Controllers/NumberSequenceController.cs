using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NibApi.Core;


namespace NibApi.Controllers
{
    [Route ("api/numbersquence")]
    public class NumberSequenceController : Controller
    {
        private INumberSequence _numberSequenceCalculation;


        public NumberSequenceController (INumberSequence numberSequenceCalculation)
        {
            _numberSequenceCalculation = numberSequenceCalculation;
        }

        [HttpGet("allnumber/{value}")]
        public async Task<IEnumerable<int>> GetAllNumber(int value) => await _numberSequenceCalculation.GetAllNumber(value);

        [HttpGet("evennumber/{value}")]
        public async Task<IEnumerable<int>> GetEvenNumber(int value) => await _numberSequenceCalculation.GetEvenNumber(value);


        [HttpGet("oddnumber/{value}")]
        public async Task<IEnumerable<int>> GetOddNumber(int value) => await _numberSequenceCalculation.GetOddNumber(value);


        [HttpGet("AllNumberCharacter/{value}")]
        public async Task<IEnumerable> GetAllNumberCharacter(int value)
        { 
            var result = await _numberSequenceCalculation.GetAllNumberCharacter(value);
            if (result == null)
                return await GetAllNumber(value);

            return  result.ToList();
        }

       
    }
}