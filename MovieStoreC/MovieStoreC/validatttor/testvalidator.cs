using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using MovieStoreC.Models.DTO;
using MovieStoreC.Models.Requests;

namespace MovieStoreC.validatttor
{
    public class testvalidator :AbstractValidator <AddMovieRequest>
    
    {
        public testvalidator() {
            RuleFor(x=> x.Year)
                .GreaterThan(0)
                .LessThan(2025);
            RuleFor(x => x.Title)
                .Length(10)
                .MinimumLength(20);
                
        
        
        }
   
    }

}
