#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

namespace VLB
{
    public static class EditorStrings
    {
        public static readonly GUIContent HeaderBasic = new GUIContent("Basic", "Basic beam's properties (color, angle, thickness...)");
        public static readonly GUIContent HeaderAttenuation = new GUIContent("Fall-Off Attenuation", "Control the beam's range distance and the light fall-off behaviour");
        public static readonly GUIContent Header3DNoise = new GUIContent("3D Noise", "Simulate animated volumetric fog / mist / smoke effects.\nIt makes the volumetric lights look less 'perfect' and so much more realistic.\nTo achieve that, a tiled 3D noise texture is internally loaded and used by the beam shader.");
        public static readonly GUIContent HeaderBlendingDistances = new GUIContent("Soft Intersections Blending Distances", "Because the volumetric beams are rendered using cone geometry, it is possible that it intersects with the camera's near plane or with the world's geometry, which could produce unwanted artifacts.\nThese properties are designed to fix this issue.");
        public static readonly GUIContent HeaderGeometry = new GUIContent("Cone Geometry", "Control how the beam's geometry is generated.");
        public static readonly GUIContent HeaderFadeOut = new GUIContent("Fade Out");
        public static readonly GUIContent Header2D = new GUIContent("2D", "Tweak and combine the order when beams are rendered with 2D objects (such as 2D sprites)");
        public static readonly GUIContent HeaderInfos = new GUIContent("Infos");

        public static readonly GUIContent FromSpotLight = new GUIContent("From Spot", "Get the value from the Light Spot");

        public static readonly GUIContent SideThickness = new GUIContent(
            "Side Thickness",
            "Thickness of the beam when looking at it from the side.\n1 = the beam is fully visible (no difference between the center and the edges), but produces hard edges.\nLower values produce softer transition at beam edges.");

        public static readonly GUIContent ColorMode = new GUIContent("Color", "Apply a flat/plain/single color, or a gradient.");
        public static readonly GUIContent ColorGradient = new GUIContent("", "Use the gradient editor to set color and alpha variations along the beam.");
        public static readonly GUIContent ColorFlat = new GUIContent("", "Use the color picker to set a plain RGBA color (takes account of the alpha value).");

        public static readonly GUIContent IntensityModeAdvanced = new GUIContent("Adv", "Advanced Mode: control inside and outside intensity values independently.");
        public static readonly GUIContent IntensityGlobal = new GUIContent("Intensity", "Global beam intensity. If you want to control values for inside and outside independently, use the advanced mode.");
        public static readonly GUIContent IntensityOutside = new GUIContent("Intensity (outside)", "Beam outside intensity (when looking at the beam from behind).");
        public static readonly GUIContent IntensityInside = new GUIContent("Intensity (inside)",  "Beam inside intensity (when looking at the beam from the inside directly at the source).");

        public static readonly GUIContent BlendingMode = new GUIContent("Blending Mode", "Additive: highly recommended blending mode\nSoftAdditive: softer additive\nTraditional Transparency: support dark/black colors");

        public static readonly GUIContent SpotAngle = new GUIContent("Spot Angle", "Define the angle (in degrees) at the base of the beam's cone");

        public static readonly GUIContent GlareFrontal = new GUIContent("Glare (frontal)", "Boost intensity factor when looking at the beam from the inside directly at the source.");
        public static readonly GUIContent GlareBehind  = new GUIContent("Glare (from behind)", "Boost intensity factor when looking at the beam from behind.");

        public static readonly GUIContent TrackChanges = new GUIContent(
            " Track changes during Playtime",
            "Check this box to be able to modify properties during Playtime via Script, Animator and/or Timeline.\nEnabling this feature is at very minor performance cost. So keep it disabled if you don't plan to modify this light beam during playtime.");

        public static readonly GUIContent AttenuationEquation = new GUIContent("Equation", "Attenuation equation used to compute fading between 'Fade Start Distance' and 'Range Distance'.\n- Linear: Simple linear attenuation\n- Quadratic: Quadratic attenuation, which usually gives more realistic results\n- Blend: Custom blending mix between linear (0.0) and quadratic attenuation (1.0)");
        public static readonly GUIContent AttenuationCustomBlending = new GUIContent("", "Blending value between Linear (0.0) and Quadratic (1.0) attenuation equations.");

        public static readonly GUIContent FallOffStart = new GUIContent("Start Distance", "Distance from the light source (in units) the beam intensity will start to fall-off.");
        public static readonly GUIContent FallOffEnd = new GUIContent("Range Limit", "Distance from the light source (in units) the beam is entirely faded out");

        public static readonly GUIContent NoiseMode = new GUIContent("Enabled", "Enable 3D Noise effect and choose the mode:\n- World Space: the noise will look 'grounded' in the world\n- Local Space: the noise will look 'tied' to the beam");
        public static readonly GUIContent NoiseIntensity = new GUIContent("Intensity", "Higher intensity means the noise contribution is stronger and more visible");
        public static readonly GUIContent NoiseScale = new GUIContent("Scale", "3D Noise texture scaling: higher scale make the noise more visible, but potentially less realistic");
        public static readonly GUIContent NoiseVelocity = new GUIContent("Velocity", "World Space direction and speed of the noise scrolling, simulating the fog/smoke movement");
        public static readonly GUIContent[] NoiseModeEnumDescriptions = new GUIContent[]
        {
            new GUIContent("Disabled"),
            new GUIContent("Enabled (World Space)"),
            new GUIContent("Enabled (Local Space)"),
        };

        public static readonly GUIContent CameraClippingDistance = new GUIContent("Camera", "Distance from the camera the beam will fade with.\n- 0.0: hard intersection\n- Higher values produce soft intersection when the camera is near the cone triangles.");
        public static readonly GUIContent DepthBlendDistance = new GUIContent("Opaque geometry", "Distance from the world geometry the beam will fade with.\n- 0.0 (feature disabled): hard intersection but faster (doesn't require to update the depth texture).\n- Higher values produce soft intersection when the beam intersects world's geometry, but require to update the camera's depth texture.");

        public static readonly GUIContent ConeRadiusStart = new GUIContent("Truncated Radius", "Radius (in units) at the beam's source (the top of the cone).\n0 will generate a perfect cone geometry.\nHigher values will generate truncated cones.");

        public static readonly GUIContent GeomMeshType = new GUIContent("Mesh Type", "");
        public static readonly GUIContent GeomCap = new GUIContent("Cap", "Show Cap Geometry (only visible from inside)");
        public static readonly GUIContent GeomSides = new GUIContent("Sides", "Number of Sides of the cone.\nHigher values make the beam looks more 'round', but require more memory and graphic performance.\nA recommended value for a decent quality while keeping the poly count low is 18.");
        public static readonly GUIContent GeomSegments = new GUIContent("Segments", "Number of Segments of the cone.\nHigher values give better looking results but require more performance. We recommend at least 3 segments, specially regarding Attenuation and Gradient, otherwise the approximation could become inaccurate.\nThe longer the beam, the more segments we recommend to set.\nA recommended value is 4.");

        public static readonly GUIContent FadeOutEnabled = new GUIContent("Enabled", "Enable the fade out of the beam according to the distance to the camera.");
        public static readonly GUIContent FadeOutBegin = new GUIContent("Begin Distance", "Fade out starting distance.");
        public static readonly GUIContent FadeOutEnd   = new GUIContent("End Distance", "Fade out ending distance. Beyond this distance, the beam will be culled off to save on performance.");

        public const string SortingLayer = "Sorting Layer";
        public static readonly GUIContent SortingOrder = new GUIContent("Order in Layer", "The overlay priority within its layer. Lower numbers are rendered first and subsequent numbers overlay those below.");

        // BUTTONS
        public static readonly GUIContent ButtonResetProperties = new GUIContent("Default values", "Reset properties to their default values.");
        public static readonly GUIContent ButtonGenerateGeometry = new GUIContent("Regenerate geometry", "Force to re-create the Beam Geometry GameObject.");
        public static readonly GUIContent ButtonAddDustParticles = new GUIContent("+ Dust Particles", "Add highly detailed dustlight / mote particles on your beam");
        public static readonly GUIContent ButtonAddDynamicOcclusion = new GUIContent("+ Dynamic Occlusion", "Gives awareness to your beam so it reacts to changes in the world: it could be occluded by environment geometry.");
        public static readonly GUIContent ButtonAddTriggerZone = new GUIContent("+ Trigger Zone", "Track objects passing through the light beam and track when the beam is passing over them.");
        public static readonly GUIContent ButtonOpenGlobalConfig = new GUIContent("Open Config Asset in use");

        // HELP BOXES
        public const string HelpNoSpotlight = "To bind properties from the Light and the Beam together, this component must be attached to a Light of type 'Spot'";
        public const string HelpNoiseLoadingFailed = "Fail to load 3D noise texture. Please check your Config.";
        public const string HelpAnimatorWarning = "If you want to animate your light beam in real-time, you should enable the 'trackChangesDuringPlaytime' property.";
        public const string HelpTrackChangesEnabled = "This beam will keep track of the changes of its own properties and the spotlight attached to it (if any) during playtime. You can modify every properties except 'geomSides'.";
        public const string HelpDepthTextureMode = "To support 'Soft Intersection with Opaque Geometry', your camera must use 'DepthTextureMode.Depth'.";
        public const string HelpDepthMobile = "On mobile platforms, the depth buffer precision can be pretty low. Try to keep a small depth range on your cameras: the difference between the near and far clip planes should stay as low as possible.";
        public const string HelpFadeOutNoMainCamera = "Fail to retrieve the main camera specified in the config.";

        // DYNAMIC OCCLUSION
        public static readonly GUIContent DynOcclusionHeaderRaycasting = new GUIContent("Raycasting");
        public static readonly GUIContent DynOcclusionHeaderOccluderSurface = new GUIContent("Occluder Surface");
        public static readonly GUIContent DynOcclusionHeaderClippingPlane = new GUIContent("Clipping Plane");
        public static readonly GUIContent DynOcclusionHeaderEditorDebug = new GUIContent("Editor Debug");

        public static readonly GUIContent DynOcclusionDimensions = new GUIContent("Dimensions", "Should it interact with 2D or 3D occluders?");
        public static readonly GUIContent[] DynOcclusionDimensionsEnumDescriptions = new GUIContent[]
        {
            new GUIContent("3D"),
            new GUIContent("2D"),
        };
        public static readonly GUIContent DynOcclusionLayerMask = new GUIContent("Layer Mask",
            "On which layers the beam will perform raycasts to check for colliders.\nTry to set it as restrictive as possible (checking only the layers which are necessary) to perform more efficient raycasts in order to increase the performance.");
        public static readonly GUIContent DynOcclusionConsiderTriggers = new GUIContent("Consider Triggers",
            "Should this beam be occluded by triggers or not?");
        public const string DynOcclusionConsiderTriggersNoPossible = "In order to be able to consider triggers as 2D occluders, you should tick the 'Queries Hit Triggers' checkbox under the 'Physics 2D' settings menu.";
        public static readonly GUIContent DynOcclusionMinOccluderArea = new GUIContent("Min Occluder Area",
            "Minimum 'area' of the collider to become an occluder.\nColliders smaller than this value will not block the beam.");
        public static readonly GUIContent DynOcclusionWaitFrameCount = new GUIContent("Wait frame count",
            "How many frames we wait between 2 occlusion tests?\nIf you want your beam to be super responsive to the changes of your environment, update it every frame by setting 1.\nIf you want to save on performance, we recommend to wait few frames between each update by setting a higher value.");
        public static readonly GUIContent DynOcclusionMinSurfaceRatio = new GUIContent("Min Occluded %", "Approximated percentage of the beam to collide with the surface in order to be considered as occluder.");
        public static readonly GUIContent DynOcclusionMaxSurfaceDot = new GUIContent("Max Angle", "Max angle (in degrees) between the beam and the surface in order to be considered as occluder.");
        public static readonly GUIContent DynOcclusionPlaneAlignment = new GUIContent("Alignment", "Alignment of the computed clipping plane:\n- Surface: align to the surface normal which blocks the beam. Works better for large occluders such as floors and walls.\n- Beam: keep the plane aligned with the beam direction. Works better with more complex occluders or with corners.");
        public static readonly GUIContent DynOcclusionPlaneOffset = new GUIContent("Offset Units", "Translate the plane. We recommend to set a small positive offset in order to handle non-flat surface better.");
        public static readonly GUIContent DynOcclusionFadeDistanceToPlane = new GUIContent("Fade Distance Units", "Fade out the beam before the computed clipping plane in order to soften the transition.");
        public static readonly GUIContent DynOcclusionEditorShowDebugPlane = new GUIContent("Show Debug Plane", "Draw debug plane on the scene view.");
        public static readonly GUIContent DynOcclusionEditorRaycastAtEachFrame = new GUIContent("Update in Editor", "Perform occlusion tests and raycasts in Editor.");

        // CONFIGS
        public static readonly GUIContent ConfigGeometryOverrideLayer = new GUIContent("Override Layer", "The layer the GameObjects holding the procedural cone meshes are created on");
        public static readonly GUIContent ConfigGeometryTag = new GUIContent("Tag", "The tag applied on the procedural geometry GameObjects");
        public static readonly GUIContent ConfigGeometryRenderQueue = new GUIContent("Render Queue", "Determine in which order beams are rendered compared to other objects.\nThis way for example transparent objects are rendered after opaque objects, and so on.");
        public static readonly GUIContent ConfigGeometryRenderPipeline = new GUIContent("Render Pipeline", "Select the Render Pipeline (Built-In or SRP) in use.");
        public static readonly GUIContent ConfigGeometryRenderingMode = new GUIContent("Rendering Mode",
@"- Multi-Pass: Use the 2 pass shader. Will generate 2 drawcalls per beam (Not compatible with custom Render Pipeline such as HDRP and LWRP).
- Single-Pass: Use the 1 pass shader. Will generate 1 drawcall per beam.
- GPU Instancing: Dynamically batch multiple beams to combine and reduce draw calls.");

        public const string ConfigSrpAndMultiPassNoCompatible = "Using a Scriptable Render Pipeline with Multi-Pass Rendering Mode is not supported:\nplease choose either the Single-Pass or GPU Instancing Rendering Mode";
        public const string ConfigGeometryGpuInstancingNotSupported = "GPU Instancing Rendering Mode is only supported on Unity 5.6 or above!\nSingle Pass will be used.";

        public static readonly GUIContent ConfigFadeOutCameraTag = new GUIContent("Fade Out Camera Tag", "Tag used to retrieve the camera used to compute the fade out factor on beams");

        public static readonly GUIContent ConfigBeamShader1Pass = new GUIContent("Shader (single-pass)", "Main shader (1 pass version) applied to the cone beam geometry");
        public static readonly GUIContent ConfigBeamShader2Pass = new GUIContent("Shader (multi-pass)", "Main shader (multi-pass version) applied to the cone beam geometry");
        public static readonly GUIContent ConfigSharedMeshSides = new GUIContent("Sides", "Number of Sides of the cone.\nHigher values make the beam looks more 'round', but require more memory and graphic performance.\nA recommended value for a decent quality while keeping the poly count low is 18.");
        public static readonly GUIContent ConfigSharedMeshSegments = new GUIContent("Segments", "Number of Segments of the cone.\nHigher values give better looking results but require more performance. We recommend at least 3 segments, specially regarding Attenuation and Gradient, otherwise the approximation could become inaccurate.\nThe longer the beam, the more segments we recommend to set.\nA recommended value is 4.");
        public static readonly GUIContent ConfigGlobalNoiseScale = new GUIContent("Scale", "Global 3D Noise texture scaling: higher scale make the noise more visible, but potentially less realistic");
        public static readonly GUIContent ConfigGlobalNoiseVelocity = new GUIContent("Velocity", "Global World Space direction and speed of the noise scrolling, simulating the fog/smoke movement");
        public static readonly GUIContent ConfigNoise3DData = new GUIContent("3D Noise Data binary file", "Binary file holding the 3D Noise texture data (a 3D array). Must be exactly Size * Size * Size bytes long.");
        public static readonly GUIContent ConfigNoise3DSize = new GUIContent("3D Noise Data dimension", "Size (of one dimension) of the 3D Noise data. Must be power of 2. So if the binary file holds a 32x32x32 texture, this value must be 32.");
        public static readonly GUIContent ConfigDustParticlesPrefab = new GUIContent("Dust Particles Prefab", "ParticleSystem prefab instantiated for the Volumetric Dust Particles feature (Unity 5.5 or above)");
        public static readonly GUIContent ConfigOpenDocumentation = new GUIContent("Documentation", "Open the online documentation."); 
        public static readonly GUIContent ConfigResetToDefaultButton = new GUIContent("Default values", "Reset properties to their default values.");

        public static readonly GUIContent[] ConfigGeometryRenderPipelineEnumDescriptions = new GUIContent[]
        {
            new GUIContent("Built-In"),
            new GUIContent("SRP 4.0.0 or higher"),
        };

        public static readonly GUIContent ConfigCreateOverrideAsset = new GUIContent("Create a 'Config Override' asset to edit these properties", "");
    
        public static readonly string ConfigMultipleAssets = string.Format(
            "This overridden Config asset is not the one in use, please make sure:\n- This asset is directly located under a 'Resources' folder.\n- This asset is named {0}.asset.\n- You only have 1 '{1}' asset in your project."
            , ConfigOverride.kAssetName
            , typeof(ConfigOverride).ToString()
            );
    }
}
#endif
