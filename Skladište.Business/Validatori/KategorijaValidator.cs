using FluentValidation;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Skladište.Shared.BindingModel;

namespace Skladište.Business.Validatori;

public class KategorijaValidator : AbstractValidator<KategorijaBM>
{
    public KategorijaValidator()
    {
        RuleFor(Stavka => Stavka.Naziv).NotNull();

    }

}

