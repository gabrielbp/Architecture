using Architecture.SOLID.DependencyInversionPrinciple.Interfaces;

namespace Architecture.SOLID.DependencyInversionPrinciple
{
  public class ClientServices : IClientService
  {
    private readonly IClientRepository _clientRepository;
    private readonly IEmailServices _emailServices;

    public ClientServices(IClientRepository clientRepository, IEmailServices emailServices)
    {
      _clientRepository = clientRepository;
      _emailServices = emailServices;
    }

    public string AddClient(Client client)
    {
      if (!client.IsValid())
        return Properties.Resources.InvalidClient;
            
      _clientRepository.AddClient(client);
      _emailServices.Send(
        "gabriel@gabriel.com.br",
        client.Email,
        Properties.Resources.ClientWelcome,
        Properties.Resources.CongratulationsRegister);     

      return string.Format(Properties.Resources.AddClientSuccess, client.Name);
    }
  }
}
