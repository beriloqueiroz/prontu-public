using application.professional;

namespace infrastructure.controller;

public record AddPatientControllerInputDto(
  string Name,
  string Email,
  string Document
);

public record AddPatientControllerOutputDto(
  string Id,
  string Name,
  string Email,
  string Document,
  string ProfessionalDocument,
  PatientDefaultDto[] Patients
);

public record UpdateProfessionalControllerInputDto(
  string Name,
  string Email,
  string ProfessionalDocument
);

public record UpdateProfessionalControllerOutputDto(
  string Id,
  string Name,
  string Email,
  string Document,
  string ProfessionalDocument
);

public record UpdatePatientControllerInputDto(
  string Name,
  string Email,
  string Document,
  bool IsActive,
  PatientFinancialInfoDefaultDto? FinancialInfo,
  PatientPersonalFormDefaultDto? PersonalForm
);