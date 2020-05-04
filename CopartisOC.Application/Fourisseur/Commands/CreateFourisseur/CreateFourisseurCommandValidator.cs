using CopartisOC.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CopartisOC.Application.Fourisseur.Commands.CreateFourisseur
{
    public class CreateFourisseurCommandValidator : AbstractValidator<CreateFourisseurCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateFourisseurCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(f => f.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MustAsync(BeUniqueName).WithMessage("The specified title already exists.");
        }

        public async Task<bool> BeUniqueName(string name, CancellationToken cancellationToken)
        {
            return await _context.Fourisseurs
                .AllAsync(f => f.Name != name);
        }
    }
}
