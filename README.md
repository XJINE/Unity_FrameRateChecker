# Unity_FrameRateChecker

<img src="https://github.com/XJINE/Unity_FrameRateChecker/blob/master/Screenshot.png" width="100%" height="auto" />

Simply calculate and show frame-rate.

## Import to Your Project

You can import this asset from UnityPackage.

- [FrameRateChecker.unitypackage](https://github.com/XJINE/Unity_FrameRateChecker/blob/master/FrameRateChecker.unitypackage)

### Dependencies

You have to import following assets to use this asset.

- [Unity_SingletonMonoBehaviour](https://github.com/XJINE/Unity_SingletonMonoBehaviour)
- [Unity_DisableInInspectorAttribute](https://github.com/XJINE/Unity_DisableInInspectorAttribute)

## How to Use

You can access fps parameters like ``FpsChecker.Instance.Fps``.

If you want to check fps in current state, reset FpsChecker with ``FpsChecker.Instance.Reset();``.