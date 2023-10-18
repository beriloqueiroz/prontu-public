namespace application.professional;

public interface IAddPatientUseCase : IUsecase<AddPatientInputDto, ProfessionalDefaultDto> { };
public interface IListProfessionalUseCase : IUsecase<ListProfessionalInputDto, PaginatedList<ProfessionalDefaultDto>> { };
public interface IFindProfessionalUseCase : IUsecase<FindProfessionalInputDto, ProfessionalDefaultDto> { };
public interface IFindPatientUseCase : IUsecase<FindPatientInputDto, PatientDefaultDto> { };
public interface ICreateProfessionalUseCase : IUsecase<CreateProfessionalInputDto, CreateProfessionalOutputDto> { };
public interface IUpdateProfessionalUseCase : IUsecase<UpdateProfessionalInputDto, ProfessionalDefaultDto> { };
public interface IUpdatePatientUseCase : IUsecase<UpdatePatientInputDto, PatientDefaultDto> { };