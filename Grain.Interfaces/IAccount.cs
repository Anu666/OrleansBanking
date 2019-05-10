using System;
using System.Threading.Tasks;
using Orleans;
namespace Grain.Interfaces
{
    public interface IAccount : IGrainWithGuidKey
    {
        Task<double> GetBalance();
        Task<string> Debit(double amount);
        Task<string> Credit(double amount);
    }
}
