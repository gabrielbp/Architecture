namespace Architecture.SOLID.SingleResponsabilityPrinciple
{
  public class ClientService
  {
    public string Add(Client client)
    {
      if (!client.IsValid())
        return Properties.Resources.InvalidClient;

      var clientRepository = new ClientRepository();
      clientRepository.Add(client);

      EmailServices.Send(
        "gabriel@gabriel.com.br", 
        client.Email, 
        Properties.Resources.ClientWelcome, 
        Properties.Resources.CongratulationsRegister);

      return string.Format(Properties.Resources.AddClientSuccess, client.Name);
    }
  }
}
