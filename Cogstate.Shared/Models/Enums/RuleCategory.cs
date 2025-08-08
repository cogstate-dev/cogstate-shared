using System.ComponentModel.DataAnnotations;

namespace Cogstate.Shared.Models.Enums;

public enum RuleCategory
{
    [Display(Name = "Subject Based Rules")]
    SubjectBased,
    [Display(Name = "Visit Based Rules")]
    VisitBased,
    [Display(Name = "Rater Based Rules")]
    RaterBased
}