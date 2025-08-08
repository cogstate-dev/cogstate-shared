using System.ComponentModel.DataAnnotations;

namespace Cogstate.Shared.Models.Enums;

public enum RuleName
{
    [Display(Name = "Eligibility Rule")]
    EligibilityRule = 0,
    [Display(Name = "CDR Independent Rating")]
    CDRIndependentReviewScoreImportRule = 1,
    [Display(Name = "CDR Global Score Progression Rule")]
    CDRGlobalScoreProgression = 2,
    [Display(Name = "First N Administrations Rule")]
    FirstNAdministrations = 3,
    [Display(Name = "Targeted Visit Rule")]
    TargetedVisit = 4,
    [Display(Name = "X Month Rule")]
    XMonthRule = 5,
    [Display(Name = "X% Rule")]
    XPercentRule = 6,
    [Display(Name = "TB3 CDR Progression Event Rule")]
    CDRProgressionRule = 7,
    [Display(Name = "TB3 First Administration Rule")]
    IsltReviewCreationFirstAdministrationRule = 8,
    [Display(Name = "TB3 5% Rule")]
    IsltReviewCreation5PercentRule = 9,
    NextAdminRule = 10,
    RaterOfConcernRule = 11,
}