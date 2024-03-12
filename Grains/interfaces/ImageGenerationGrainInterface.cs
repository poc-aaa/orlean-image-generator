using Grains;
using Orleans;

namespace Shared;

public interface ISchrodingerGrain : IGrainWithGuidKey
{ }

public interface IImageGeneratorGrain : ISchrodingerGrain, IGrainWithStringKey
{
    Task SetApiKey(string key);
    
    Task<ImageGenerationGrainResponse> GenerateImageFromPromptAsync(string prompt, string imageRequestId, string parentRequestId);

    Task SetImageGenerationRequestData(string prompt, string imageRequestId, string parentRequestId);
    Task<ImageQueryGrainResponse> QueryImageAsync();
}

public interface IMultiImageGeneratorGrain : ISchrodingerGrain, IGrainWithStringKey
{
    Task<MultiImageGenerationGrainResponse> GenerateMultipleImagesAsync(List<Attribute> traits, int NumberOfImages, string multiImageRequestId);

    Task NotifyImageGenerationStatus(string imageRequestId, ImageGenerationStatus status, string? error);

    Task<MultiImageQueryGrainResponse> QueryMultipleImagesAsync();
}
