using FleetFlow.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System.Linq.Expressions;

namespace FleetFlow.Service.Interfaces;

public interface IAttachmantService
{
    ValueTask<Attachment> UploadAsync(IFile file);
    ValueTask<bool> DeleteAsync(long id);
}
