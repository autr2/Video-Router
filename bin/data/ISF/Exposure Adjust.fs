/*{
	"CREDIT": "by carter rosenberg",
	"CATEGORIES": [
		"Color Adjustment"
	],
	"INPUTS": [
		{
			"NAME": "inputImage",
			"TYPE": "image"
		},
		{
			"NAME": "inputEV",
			"TYPE": "float",
			"MIN": -5.0,
			"MAX": 5.0,
			"DEFAULT": 0.5
		}
	]
}*/



void main() {
	//	based on
	//	https://developer.apple.com/library/mac/documentation/graphicsimaging/reference/CoreImageFilterReference/Reference/reference.html#//apple_ref/doc/filter/ci/CIExposureAdjust
	vec4		tmpColorA = IMG_THIS_PIXEL(inputImage);
	tmpColorA.rgb = tmpColorA.rgb * pow(2.0, inputEV);
	gl_FragColor = tmpColorA;
}
