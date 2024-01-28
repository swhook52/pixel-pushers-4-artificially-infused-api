namespace artificially_infused.Controllers.game.Models
{
    public class AIGenerateRequest
    {
        public string prompt { get; set; }
        public string negative_prompt { get; set; }
        public List<string> style_selections { get; set; }
        public string performance_selection { get; set; }
        public string aspect_ratios_selection { get; set; }
        public int image_number { get; set; }
        public int image_seed { get; set; }
        public int sharpness { get; set; }
        public int guidance_scale { get; set; }
        public string base_model_name { get; set; }
        public string refiner_model_name { get; set; }
        public double refiner_switch { get; set; }
        public List<Lora> loras { get; set; }
        public AdvancedParams advanced_params { get; set; }
        public bool require_base64 { get; set; }
        public bool async_process { get; set; }
        public string webhook_url { get; set; }

        public static AIGenerateRequest GetDefaultRequest()
        {
            return new AIGenerateRequest
            {
                prompt = null,
                negative_prompt = "",
                style_selections = new List<string>
                {
                    "Fooocus V2",
                    "Fooocus Enhance",
                    "Fooocus Sharp"
                },
                performance_selection = "Speed",
                aspect_ratios_selection = "1152*896",
                image_number = 1,
                image_seed = -1,
                sharpness = 2,
                guidance_scale = 4,
                base_model_name = "juggernautXL_version6Rundiffusion.safetensors",
                refiner_model_name = "None",
                refiner_switch = 0.5,
                loras = new List<Lora> {
                    new Lora {
                        model_name = "sd_xl_offset_example-lora_1.0.safetensors",
                        weight = 0.1
                    }
                },
                advanced_params = new AdvancedParams {
                    adaptive_cfg = 7,
                    adm_scaler_end = 0.3,
                    adm_scaler_negative = 0.8,
                    adm_scaler_positive = 1.5,
                    canny_high_threshold = 128,
                    canny_low_threshold = 64,
                    controlnet_softness = 0.25,
                    debugging_cn_preprocessor = false,
                    debugging_inpaint_preprocessor = false,
                    disable_preview = false,
                    freeu_b1 = 1.01,
                    freeu_b2 = 1.02,
                    freeu_enabled = false,
                    freeu_s1 = 0.99,
                    freeu_s2 = 0.95,
                    inpaint_disable_initial_latent = false,
                    inpaint_engine = "v1",
                    inpaint_erode_or_dilate = 0,
                    inpaint_respective_field = 1,
                    inpaint_strength = 1,
                    invert_mask_checkbox = false,
                    mixing_image_prompt_and_inpaint = false,
                    mixing_image_prompt_and_vary_upscale = false,
                    overwrite_height = -1,
                    overwrite_step = -1,
                    overwrite_switch = -1,
                    overwrite_upscale_strength = -1,
                    overwrite_vary_strength = -1,
                    overwrite_width = -1,
                    refiner_swap_method = "joint",
                    sampler_name = "dpmpp_2m_sde_gpu",
                    scheduler_name = "karras",
                    skipping_cn_preprocessor = false
                },
                require_base64 = false,
                async_process = false,
                webhook_url = ""
            };
        }
    }

    public class AdvancedParams
    {
        public int adaptive_cfg { get; set; }
        public double adm_scaler_end { get; set; }
        public double adm_scaler_negative { get; set; }
        public double adm_scaler_positive { get; set; }
        public int canny_high_threshold { get; set; }
        public int canny_low_threshold { get; set; }
        public double controlnet_softness { get; set; }
        public bool debugging_cn_preprocessor { get; set; }
        public bool debugging_inpaint_preprocessor { get; set; }
        public bool disable_preview { get; set; }
        public double freeu_b1 { get; set; }
        public double freeu_b2 { get; set; }
        public bool freeu_enabled { get; set; }
        public double freeu_s1 { get; set; }
        public double freeu_s2 { get; set; }
        public bool inpaint_disable_initial_latent { get; set; }
        public string inpaint_engine { get; set; }
        public int inpaint_erode_or_dilate { get; set; }
        public int inpaint_respective_field { get; set; }
        public int inpaint_strength { get; set; }
        public bool invert_mask_checkbox { get; set; }
        public bool mixing_image_prompt_and_inpaint { get; set; }
        public bool mixing_image_prompt_and_vary_upscale { get; set; }
        public int overwrite_height { get; set; }
        public int overwrite_step { get; set; }
        public int overwrite_switch { get; set; }
        public int overwrite_upscale_strength { get; set; }
        public int overwrite_vary_strength { get; set; }
        public int overwrite_width { get; set; }
        public string refiner_swap_method { get; set; }
        public string sampler_name { get; set; }
        public string scheduler_name { get; set; }
        public bool skipping_cn_preprocessor { get; set; }
    }

    public class Lora
    {
        public string model_name { get; set; }
        public double weight { get; set; }
    }
}
