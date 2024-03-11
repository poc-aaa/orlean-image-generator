using Shared;
using Attribute = Shared.Attribute;

namespace Grains;

public class MultiImageGenerationState
{

    public string RequestId { get; set; }

    public List<Attribute> Traits { get; set; }

    public string Prompt { get; set; }

    public bool IsSuccessful { get; set; }


    public List<string>? Errors { get; set; }

   public List<string> ImageGenerationRequestIds = new List<string>();

   public Dictionary<string, ImageGenerationNotification> imageGenerationTracker = new();
}

public class ImageGenerationNotification
{
    public string RequestId { get; set; }

    public ImageGenerationStatus Status { get; set; }

    public string? Error { get; set; }

    public string? ImageUrl { get; set; }
}
