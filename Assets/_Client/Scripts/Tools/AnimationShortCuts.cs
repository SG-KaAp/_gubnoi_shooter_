﻿using DG.Tweening;
using UnityEngine;

public static class AnimationShortCuts
{
    // public static Tween FadeAnimation(this Graphic graphic, FadeAnimationPreset preset)
    // {
    //     return graphic
    //         .DOFade(preset.value, preset.duration)
    //         .SetEase(preset.ease)
    //         .SetLink(graphic.gameObject);
    // }
    
    // public static Tween FadeIn(this Graphic graphic, in float duration = 1f, in Ease ease = Ease.Linear)
    // {
    //     return graphic
    //         .DOFade(1f, duration)
    //         .SetEase(ease)
    //         .SetLink(graphic.gameObject);
    // }
    
    // public static Tween FadeOut(this Graphic graphic, in float duration = 1f, in Ease ease = Ease.Linear)
    // {
    //     return graphic
    //         .DOFade(0f, duration)
    //         .SetEase(ease)
    //         .SetLink(graphic.gameObject);
    // }

    // public static Tween JumpAnimation(this Transform transform, in Vector3 endPosition, JumpAnimationPreset preset)
    // {
    //     return transform
    //         .DOJump(endPosition, preset.jumpPower, preset.jumpCount, preset.duration)
    //         .SetEase(preset.ease)
    //         .SetLink(transform.gameObject);
    // }

    // public static Tween MoveAnimation(this Transform transform, in Vector3 endPosition, AnimationPreset preset)
    // {
    //     return transform
    //         .DOMove(endPosition, preset.duration)
    //         .SetEase(preset.ease)
    //         .SetLink(transform.gameObject);
    // }

    // public static Tween ScaleAnimation(this Transform transform, ScaleAnimationPreset preset)
    // {
    //     return transform
    //         .DOScale(preset.value, preset.duration)
    //         .SetEase(preset.ease)
    //         .SetLink(transform.gameObject);
    // }

    public static Tween ShakeRotationAnimation(this Transform transform, ShakeAnimationConfig config)
    {
        return transform
            .DOShakeRotation(config.Duration, config.Strength, config.Vibrato, config.Randomness, randomnessMode: config.RandomnessMode)
            .SetEase(config.ease);
    }
    
    public static Tween ShakePositionAnimation(this Transform transform, ShakeAnimationConfig config)
    {
        return transform
            .DOShakePosition(config.Duration, config.Strength, config.Vibrato, config.Randomness, config.Snapping, true, config.RandomnessMode)
            .SetEase(config.ease);
    }

    // public static Tween PunchPositionAnimation(this Transform transform, PunchAnimationPreset preset)
    // {
    //     return transform
    //         .DOPunchPosition(preset.direction, preset.duration, preset.vibrato, preset.elasticity, preset.snapping)
    //         .SetEase(preset.ease)
    //         .SetLink(transform.gameObject);
    // }
    
    // public static Tween PunchRotationAnimation(this Transform transform, PunchAnimationPreset preset)
    // {
    //     return transform
    //         .DOPunchRotation(preset.direction, preset.duration, preset.vibrato, preset.elasticity)
    //         .SetEase(preset.ease)
    //         .SetLink(transform.gameObject);
    // }

    // public static Tween ScaleAnimationLoop(this Transform transform, ScaleAnimationPreset preset)
    // {
    //     return ScaleAnimation(transform, preset).SetLoops(-1, LoopType.Yoyo);
    // }
    
    // public static Tween PopEffect(this Component component, 
    //     in Vector3 regularScale, in float scalePercent = 1.1f, in float duration = 0.1f)
    // {
    //     var transform = component.transform;
        
    //     transform.DOKill();

    //     return transform.
    //         DOScale(regularScale * scalePercent, duration).
    //         SetEase(Ease.InOutCirc).
    //         SetLoops(2, LoopType.Yoyo).
    //         SetLink(component.gameObject).
    //         From(regularScale);
    // }

    // public static Tween PopEffect(this Component component, 
    //     in float scalePercent = 1.1f, in float duration = 0.1f)
    // {
    //     return PopEffect(component, Vector3.one, scalePercent, duration);
    // }
}