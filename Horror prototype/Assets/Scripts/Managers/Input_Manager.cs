using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Input_Manager : MonoBehaviour
{
    [Header("Exposed Variables")]
    public Text buttonTextInteract;
    public Text buttonTextMovementUp;
    public Text buttonTextMovementDown;
    public Text buttonTextMovementLeft;
    public Text buttonTextMovementRight;

    public static bool Interact()
    {
        return GetInputDown("Input_Interact") > 0;
    }

    public static Vector2 Movement()
    {
        return new Vector2(
            Convert.ToInt32(GetInput("Input_Movement_Right")) - Convert.ToInt32(GetInput("Input_Movement_Left")),
            Convert.ToInt32(GetInput("Input_Movement_Up")) - Convert.ToInt32(GetInput("Input_Movement_Down")));
    }

    public static float GetInput(string _key)
    {
        int key = PlayerPrefs.GetInt(_key);
        switch (key)
        {
            case 0:
                return 0.0f;
            case 8:
                return Convert.ToInt32(Input.GetKey(KeyCode.Backspace));
            case 9:
                return Convert.ToInt32(Input.GetKey(KeyCode.Tab));
            case 12:
                return Convert.ToInt32(Input.GetKey(KeyCode.Clear));
            case 13:
                return Convert.ToInt32(Input.GetKey(KeyCode.Return));
            case 19:
                return Convert.ToInt32(Input.GetKey(KeyCode.Pause));
            case 27:
                return Convert.ToInt32(Input.GetKey(KeyCode.Escape));
            case 32:
                return Convert.ToInt32(Input.GetKey(KeyCode.Space));
            case 33:
                return Convert.ToInt32(Input.GetKey(KeyCode.Exclaim));
            case 34:
                return Convert.ToInt32(Input.GetKey(KeyCode.DoubleQuote));
            case 35:
                return Convert.ToInt32(Input.GetKey(KeyCode.Hash));
            case 36:
                return Convert.ToInt32(Input.GetKey(KeyCode.Dollar));
            case 37:
                return Convert.ToInt32(Input.GetKey(KeyCode.Percent));
            case 38:
                return Convert.ToInt32(Input.GetKey(KeyCode.Ampersand));
            case 39:
                return Convert.ToInt32(Input.GetKey(KeyCode.Quote));
            case 40:
                return Convert.ToInt32(Input.GetKey(KeyCode.LeftParen));
            case 41:
                return Convert.ToInt32(Input.GetKey(KeyCode.RightParen));
            case 42:
                return Convert.ToInt32(Input.GetKey(KeyCode.Asterisk));
            case 43:
                return Convert.ToInt32(Input.GetKey(KeyCode.Plus));
            case 44:
                return Convert.ToInt32(Input.GetKey(KeyCode.Comma));
            case 45:
                return Convert.ToInt32(Input.GetKey(KeyCode.Minus));
            case 46:
                return Convert.ToInt32(Input.GetKey(KeyCode.Period));
            case 47:
                return Convert.ToInt32(Input.GetKey(KeyCode.Slash));
            case 48:
                return Convert.ToInt32(Input.GetKey(KeyCode.Alpha0));
            case 49:
                return Convert.ToInt32(Input.GetKey(KeyCode.Alpha1));
            case 50:
                return Convert.ToInt32(Input.GetKey(KeyCode.Alpha2));
            case 51:
                return Convert.ToInt32(Input.GetKey(KeyCode.Alpha3));
            case 52:
                return Convert.ToInt32(Input.GetKey(KeyCode.Alpha4));
            case 53:
                return Convert.ToInt32(Input.GetKey(KeyCode.Alpha5));
            case 54:
                return Convert.ToInt32(Input.GetKey(KeyCode.Alpha6));
            case 55:
                return Convert.ToInt32(Input.GetKey(KeyCode.Alpha7));
            case 56:
                return Convert.ToInt32(Input.GetKey(KeyCode.Alpha8));
            case 57:
                return Convert.ToInt32(Input.GetKey(KeyCode.Alpha9));
            case 58:
                return Convert.ToInt32(Input.GetKey(KeyCode.Colon));
            case 59:
                return Convert.ToInt32(Input.GetKey(KeyCode.Semicolon));
            case 60:
                return Convert.ToInt32(Input.GetKey(KeyCode.Less));
            case 61:
                return Convert.ToInt32(Input.GetKey(KeyCode.Equals));
            case 62:
                return Convert.ToInt32(Input.GetKey(KeyCode.Greater));
            case 63:
                return Convert.ToInt32(Input.GetKey(KeyCode.Question));
            case 64:
                return Convert.ToInt32(Input.GetKey(KeyCode.At));
            case 91:
                return Convert.ToInt32(Input.GetKey(KeyCode.LeftBracket));
            case 92:
                return Convert.ToInt32(Input.GetKey(KeyCode.Backslash));
            case 93:
                return Convert.ToInt32(Input.GetKey(KeyCode.RightBracket));
            case 94:
                return Convert.ToInt32(Input.GetKey(KeyCode.Caret));
            case 95:
                return Convert.ToInt32(Input.GetKey(KeyCode.Underscore));
            case 96:
                return Convert.ToInt32(Input.GetKey(KeyCode.BackQuote));
            case 97:
                return Convert.ToInt32(Input.GetKey(KeyCode.A));
            case 98:
                return Convert.ToInt32(Input.GetKey(KeyCode.B));
            case 99:
                return Convert.ToInt32(Input.GetKey(KeyCode.C));
            case 100:
                return Convert.ToInt32(Input.GetKey(KeyCode.D));
            case 101:
                return Convert.ToInt32(Input.GetKey(KeyCode.E));
            case 102:
                return Convert.ToInt32(Input.GetKey(KeyCode.F));
            case 103:
                return Convert.ToInt32(Input.GetKey(KeyCode.G));
            case 104:
                return Convert.ToInt32(Input.GetKey(KeyCode.H));
            case 105:
                return Convert.ToInt32(Input.GetKey(KeyCode.I));
            case 106:
                return Convert.ToInt32(Input.GetKey(KeyCode.J));
            case 107:
                return Convert.ToInt32(Input.GetKey(KeyCode.K));
            case 108:
                return Convert.ToInt32(Input.GetKey(KeyCode.L));
            case 109:
                return Convert.ToInt32(Input.GetKey(KeyCode.M));
            case 110:
                return Convert.ToInt32(Input.GetKey(KeyCode.N));
            case 111:
                return Convert.ToInt32(Input.GetKey(KeyCode.O));
            case 112:
                return Convert.ToInt32(Input.GetKey(KeyCode.P));
            case 113:
                return Convert.ToInt32(Input.GetKey(KeyCode.Q));
            case 114:
                return Convert.ToInt32(Input.GetKey(KeyCode.R));
            case 115:
                return Convert.ToInt32(Input.GetKey(KeyCode.S));
            case 116:
                return Convert.ToInt32(Input.GetKey(KeyCode.T));
            case 117:
                return Convert.ToInt32(Input.GetKey(KeyCode.U));
            case 118:
                return Convert.ToInt32(Input.GetKey(KeyCode.V));
            case 119:
                return Convert.ToInt32(Input.GetKey(KeyCode.W));
            case 120:
                return Convert.ToInt32(Input.GetKey(KeyCode.X));
            case 121:
                return Convert.ToInt32(Input.GetKey(KeyCode.Y));
            case 122:
                return Convert.ToInt32(Input.GetKey(KeyCode.Z));
            case 123:
                return Convert.ToInt32(Input.GetKey(KeyCode.LeftCurlyBracket));
            case 124:
                return Convert.ToInt32(Input.GetKey(KeyCode.Pipe));
            case 125:
                return Convert.ToInt32(Input.GetKey(KeyCode.RightCurlyBracket));
            case 126:
                return Convert.ToInt32(Input.GetKey(KeyCode.Tilde));
            case 127:
                return Convert.ToInt32(Input.GetKey(KeyCode.Delete));
            case 256:
                return Convert.ToInt32(Input.GetKey(KeyCode.Keypad0));
            case 257:
                return Convert.ToInt32(Input.GetKey(KeyCode.Keypad1));
            case 258:
                return Convert.ToInt32(Input.GetKey(KeyCode.Keypad2));
            case 259:
                return Convert.ToInt32(Input.GetKey(KeyCode.Keypad3));
            case 260:
                return Convert.ToInt32(Input.GetKey(KeyCode.Keypad4));
            case 261:
                return Convert.ToInt32(Input.GetKey(KeyCode.Keypad5));
            case 262:
                return Convert.ToInt32(Input.GetKey(KeyCode.Keypad6));
            case 263:
                return Convert.ToInt32(Input.GetKey(KeyCode.Keypad7));
            case 264:
                return Convert.ToInt32(Input.GetKey(KeyCode.Keypad8));
            case 265:
                return Convert.ToInt32(Input.GetKey(KeyCode.Keypad9));
            case 266:
                return Convert.ToInt32(Input.GetKey(KeyCode.KeypadPeriod));
            case 267:
                return Convert.ToInt32(Input.GetKey(KeyCode.KeypadDivide));
            case 268:
                return Convert.ToInt32(Input.GetKey(KeyCode.KeypadMultiply));
            case 269:
                return Convert.ToInt32(Input.GetKey(KeyCode.KeypadMinus));
            case 270:
                return Convert.ToInt32(Input.GetKey(KeyCode.KeypadPlus));
            case 271:
                return Convert.ToInt32(Input.GetKey(KeyCode.KeypadEnter));
            case 272:
                return Convert.ToInt32(Input.GetKey(KeyCode.KeypadEquals));
            case 273:
                return Convert.ToInt32(Input.GetKey(KeyCode.UpArrow));
            case 274:
                return Convert.ToInt32(Input.GetKey(KeyCode.DownArrow));
            case 275:
                return Convert.ToInt32(Input.GetKey(KeyCode.RightArrow));
            case 276:
                return Convert.ToInt32(Input.GetKey(KeyCode.LeftArrow));
            case 277:
                return Convert.ToInt32(Input.GetKey(KeyCode.Insert));
            case 278:
                return Convert.ToInt32(Input.GetKey(KeyCode.Home));
            case 279:
                return Convert.ToInt32(Input.GetKey(KeyCode.End));
            case 280:
                return Convert.ToInt32(Input.GetKey(KeyCode.PageUp));
            case 281:
                return Convert.ToInt32(Input.GetKey(KeyCode.PageDown));
            case 282:
                return Convert.ToInt32(Input.GetKey(KeyCode.F1));
            case 283:
                return Convert.ToInt32(Input.GetKey(KeyCode.F2));
            case 284:
                return Convert.ToInt32(Input.GetKey(KeyCode.F3));
            case 285:
                return Convert.ToInt32(Input.GetKey(KeyCode.F4));
            case 286:
                return Convert.ToInt32(Input.GetKey(KeyCode.F5));
            case 287:
                return Convert.ToInt32(Input.GetKey(KeyCode.F6));
            case 288:
                return Convert.ToInt32(Input.GetKey(KeyCode.F7));
            case 289:
                return Convert.ToInt32(Input.GetKey(KeyCode.F8));
            case 290:
                return Convert.ToInt32(Input.GetKey(KeyCode.F9));
            case 291:
                return Convert.ToInt32(Input.GetKey(KeyCode.F10));
            case 292:
                return Convert.ToInt32(Input.GetKey(KeyCode.F11));
            case 293:
                return Convert.ToInt32(Input.GetKey(KeyCode.F12));
            case 294:
                return Convert.ToInt32(Input.GetKey(KeyCode.F13));
            case 295:
                return Convert.ToInt32(Input.GetKey(KeyCode.F14));
            case 296:
                return Convert.ToInt32(Input.GetKey(KeyCode.F15));
            case 300:
                return Convert.ToInt32(Input.GetKey(KeyCode.Numlock));
            case 301:
                return Convert.ToInt32(Input.GetKey(KeyCode.CapsLock));
            case 302:
                return Convert.ToInt32(Input.GetKey(KeyCode.ScrollLock));
            case 303:
                return Convert.ToInt32(Input.GetKey(KeyCode.RightShift));
            case 304:
                return Convert.ToInt32(Input.GetKey(KeyCode.LeftShift));
            case 305:
                return Convert.ToInt32(Input.GetKey(KeyCode.RightControl));
            case 306:
                return Convert.ToInt32(Input.GetKey(KeyCode.LeftControl));
            case 307:
                return Convert.ToInt32(Input.GetKey(KeyCode.RightAlt));
            case 308:
                return Convert.ToInt32(Input.GetKey(KeyCode.LeftAlt));
            case 309:
                return Convert.ToInt32(Input.GetKey(KeyCode.RightApple));
            case 310:
                return Convert.ToInt32(Input.GetKey(KeyCode.LeftApple));
            case 311:
                return Convert.ToInt32(Input.GetKey(KeyCode.LeftWindows));
            case 312:
                return Convert.ToInt32(Input.GetKey(KeyCode.RightWindows));
            case 313:
                return Convert.ToInt32(Input.GetKey(KeyCode.AltGr));
            case 315:
                return Convert.ToInt32(Input.GetKey(KeyCode.Help));
            case 316:
                return Convert.ToInt32(Input.GetKey(KeyCode.Print));
            case 317:
                return Convert.ToInt32(Input.GetKey(KeyCode.SysReq));
            case 318:
                return Convert.ToInt32(Input.GetKey(KeyCode.Break));
            case 319:
                return Convert.ToInt32(Input.GetKey(KeyCode.Menu));
            case 323:
                return Convert.ToInt32(Input.GetKey(KeyCode.Mouse0));
            case 324:
                return Convert.ToInt32(Input.GetKey(KeyCode.Mouse1));
            case 325:
                return Convert.ToInt32(Input.GetKey(KeyCode.Mouse2));
            case 326:
                return Convert.ToInt32(Input.GetKey(KeyCode.Mouse3));
            case 327:
                return Convert.ToInt32(Input.GetKey(KeyCode.Mouse4));
            case 328:
                return Convert.ToInt32(Input.GetKey(KeyCode.Mouse5));
            case 329:
                return Convert.ToInt32(Input.GetKey(KeyCode.Mouse6));
            case 330:
                return Convert.ToInt32(Input.GetKey(KeyCode.JoystickButton0));
            case 331:
                return Convert.ToInt32(Input.GetKey(KeyCode.JoystickButton1));
            case 332:
                return Convert.ToInt32(Input.GetKey(KeyCode.JoystickButton2));
            case 333:
                return Convert.ToInt32(Input.GetKey(KeyCode.JoystickButton3));
            case 334:
                return Convert.ToInt32(Input.GetKey(KeyCode.JoystickButton4));
            case 335:
                return Convert.ToInt32(Input.GetKey(KeyCode.JoystickButton5));
            case 336:
                return Convert.ToInt32(Input.GetKey(KeyCode.JoystickButton6));
            case 337:
                return Convert.ToInt32(Input.GetKey(KeyCode.JoystickButton7));
            case 338:
                return Convert.ToInt32(Input.GetKey(KeyCode.JoystickButton8));
            case 339:
                return Convert.ToInt32(Input.GetKey(KeyCode.JoystickButton9));
            case 340:
                return Convert.ToInt32(Input.GetKey(KeyCode.JoystickButton10));
            case 341:
                return Convert.ToInt32(Input.GetKey(KeyCode.JoystickButton11));
            case 342:
                return Convert.ToInt32(Input.GetKey(KeyCode.JoystickButton12));
            case 343:
                return Convert.ToInt32(Input.GetKey(KeyCode.JoystickButton13));
            case 344:
                return Convert.ToInt32(Input.GetKey(KeyCode.JoystickButton14));
            case 345:
                return Convert.ToInt32(Input.GetKey(KeyCode.JoystickButton15));
            case 346:
                return Convert.ToInt32(Input.GetKey(KeyCode.JoystickButton16));
            case 347:
                return Convert.ToInt32(Input.GetKey(KeyCode.JoystickButton17));
            case 348:
                return Convert.ToInt32(Input.GetKey(KeyCode.JoystickButton18));
            case 349:
                return Convert.ToInt32(Input.GetKey(KeyCode.JoystickButton19));
            case 350:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick1Button0));
            case 351:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick1Button1));
            case 352:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick1Button2));
            case 353:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick1Button3));
            case 354:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick1Button4));
            case 355:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick1Button5));
            case 356:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick1Button6));
            case 357:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick1Button7));
            case 358:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick1Button8));
            case 359:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick1Button9));
            case 360:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick1Button10));
            case 361:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick1Button11));
            case 362:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick1Button12));
            case 363:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick1Button13));
            case 364:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick1Button14));
            case 365:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick1Button15));
            case 366:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick1Button16));
            case 367:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick1Button17));
            case 368:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick1Button18));
            case 369:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick1Button19));
            case 370:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick2Button0));
            case 371:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick2Button1));
            case 372:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick2Button2));
            case 373:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick2Button3));
            case 374:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick2Button4));
            case 375:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick2Button5));
            case 376:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick2Button6));
            case 377:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick2Button7));
            case 378:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick2Button8));
            case 379:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick2Button9));
            case 380:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick2Button10));
            case 381:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick2Button11));
            case 382:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick2Button12));
            case 383:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick2Button13));
            case 384:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick2Button14));
            case 385:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick2Button15));
            case 386:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick2Button16));
            case 387:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick2Button17));
            case 388:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick2Button18));
            case 389:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick2Button19));
            case 390:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick3Button0));
            case 391:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick3Button1));
            case 392:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick3Button2));
            case 393:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick3Button3));
            case 394:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick3Button4));
            case 395:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick3Button5));
            case 396:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick3Button6));
            case 397:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick3Button7));
            case 398:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick3Button8));
            case 399:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick3Button9));
            case 400:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick3Button10));
            case 401:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick3Button11));
            case 402:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick3Button12));
            case 403:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick3Button13));
            case 404:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick3Button14));
            case 405:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick3Button15));
            case 406:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick3Button16));
            case 407:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick3Button17));
            case 408:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick3Button18));
            case 409:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick3Button19));
            case 410:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick4Button0));
            case 411:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick4Button1));
            case 412:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick4Button2));
            case 413:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick4Button3));
            case 414:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick4Button4));
            case 415:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick4Button5));
            case 416:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick4Button6));
            case 417:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick4Button7));
            case 418:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick4Button8));
            case 419:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick4Button9));
            case 420:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick4Button10));
            case 421:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick4Button11));
            case 422:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick4Button12));
            case 423:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick4Button13));
            case 424:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick4Button14));
            case 425:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick4Button15));
            case 426:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick4Button16));
            case 427:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick4Button17));
            case 428:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick4Button18));
            case 429:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick4Button19));
            case 430:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick5Button0));
            case 431:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick5Button1));
            case 432:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick5Button2));
            case 433:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick5Button3));
            case 434:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick5Button4));
            case 435:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick5Button5));
            case 436:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick5Button6));
            case 437:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick5Button7));
            case 438:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick5Button8));
            case 439:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick5Button9));
            case 440:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick5Button10));
            case 441:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick5Button11));
            case 442:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick5Button12));
            case 443:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick5Button13));
            case 444:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick5Button14));
            case 445:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick5Button15));
            case 446:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick5Button16));
            case 447:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick5Button17));
            case 448:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick5Button18));
            case 449:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick5Button19));
            case 450:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick6Button0));
            case 451:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick6Button1));
            case 452:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick6Button2));
            case 453:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick6Button3));
            case 454:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick6Button4));
            case 455:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick6Button5));
            case 456:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick6Button6));
            case 457:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick6Button7));
            case 458:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick6Button8));
            case 459:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick6Button9));
            case 460:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick6Button10));
            case 461:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick6Button11));
            case 462:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick6Button12));
            case 463:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick6Button13));
            case 464:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick6Button14));
            case 465:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick6Button15));
            case 466:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick6Button16));
            case 467:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick6Button17));
            case 468:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick6Button18));
            case 469:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick6Button19));
            case 470:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick7Button0));
            case 471:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick7Button1));
            case 472:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick7Button2));
            case 473:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick7Button3));
            case 474:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick7Button4));
            case 475:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick7Button5));
            case 476:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick7Button6));
            case 477:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick7Button7));
            case 478:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick7Button8));
            case 479:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick7Button9));
            case 480:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick7Button10));
            case 481:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick7Button11));
            case 482:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick7Button12));
            case 483:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick7Button13));
            case 484:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick7Button14));
            case 485:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick7Button15));
            case 486:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick7Button16));
            case 487:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick7Button17));
            case 488:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick7Button18));
            case 489:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick7Button19));
            case 490:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick8Button0));
            case 491:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick8Button1));
            case 492:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick8Button2));
            case 493:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick8Button3));
            case 494:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick8Button4));
            case 495:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick8Button5));
            case 496:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick8Button6));
            case 497:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick8Button7));
            case 498:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick8Button8));
            case 499:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick8Button9));
            case 500:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick8Button10));
            case 501:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick8Button11));
            case 502:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick8Button12));
            case 503:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick8Button13));
            case 504:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick8Button14));
            case 505:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick8Button15));
            case 506:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick8Button16));
            case 507:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick8Button17));
            case 508:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick8Button18));
            case 509:
                return Convert.ToInt32(Input.GetKey(KeyCode.Joystick8Button19));
        }
        return 0.0f;
    }

    public static float GetInputDown(string _key)
    {
        int key = PlayerPrefs.GetInt(_key);
        switch (key)
        {
            case 0:
                return 0.0f;
            case 8:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Backspace));
            case 9:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Tab));
            case 12:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Clear));
            case 13:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Return));
            case 19:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Pause));
            case 27:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Escape));
            case 32:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Space));
            case 33:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Exclaim));
            case 34:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.DoubleQuote));
            case 35:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Hash));
            case 36:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Dollar));
            case 37:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Percent));
            case 38:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Ampersand));
            case 39:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Quote));
            case 40:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.LeftParen));
            case 41:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.RightParen));
            case 42:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Asterisk));
            case 43:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Plus));
            case 44:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Comma));
            case 45:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Minus));
            case 46:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Period));
            case 47:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Slash));
            case 48:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Alpha0));
            case 49:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Alpha1));
            case 50:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Alpha2));
            case 51:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Alpha3));
            case 52:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Alpha4));
            case 53:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Alpha5));
            case 54:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Alpha6));
            case 55:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Alpha7));
            case 56:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Alpha8));
            case 57:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Alpha9));
            case 58:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Colon));
            case 59:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Semicolon));
            case 60:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Less));
            case 61:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Equals));
            case 62:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Greater));
            case 63:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Question));
            case 64:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.At));
            case 91:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.LeftBracket));
            case 92:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Backslash));
            case 93:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.RightBracket));
            case 94:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Caret));
            case 95:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Underscore));
            case 96:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.BackQuote));
            case 97:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.A));
            case 98:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.B));
            case 99:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.C));
            case 100:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.D));
            case 101:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.E));
            case 102:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.F));
            case 103:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.G));
            case 104:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.H));
            case 105:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.I));
            case 106:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.J));
            case 107:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.K));
            case 108:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.L));
            case 109:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.M));
            case 110:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.N));
            case 111:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.O));
            case 112:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.P));
            case 113:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Q));
            case 114:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.R));
            case 115:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.S));
            case 116:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.T));
            case 117:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.U));
            case 118:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.V));
            case 119:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.W));
            case 120:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.X));
            case 121:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Y));
            case 122:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Z));
            case 123:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.LeftCurlyBracket));
            case 124:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Pipe));
            case 125:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.RightCurlyBracket));
            case 126:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Tilde));
            case 127:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Delete));
            case 256:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Keypad0));
            case 257:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Keypad1));
            case 258:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Keypad2));
            case 259:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Keypad3));
            case 260:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Keypad4));
            case 261:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Keypad5));
            case 262:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Keypad6));
            case 263:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Keypad7));
            case 264:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Keypad8));
            case 265:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Keypad9));
            case 266:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.KeypadPeriod));
            case 267:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.KeypadDivide));
            case 268:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.KeypadMultiply));
            case 269:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.KeypadMinus));
            case 270:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.KeypadPlus));
            case 271:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.KeypadEnter));
            case 272:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.KeypadEquals));
            case 273:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.UpArrow));
            case 274:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.DownArrow));
            case 275:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.RightArrow));
            case 276:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.LeftArrow));
            case 277:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Insert));
            case 278:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Home));
            case 279:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.End));
            case 280:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.PageUp));
            case 281:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.PageDown));
            case 282:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.F1));
            case 283:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.F2));
            case 284:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.F3));
            case 285:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.F4));
            case 286:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.F5));
            case 287:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.F6));
            case 288:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.F7));
            case 289:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.F8));
            case 290:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.F9));
            case 291:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.F10));
            case 292:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.F11));
            case 293:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.F12));
            case 294:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.F13));
            case 295:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.F14));
            case 296:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.F15));
            case 300:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Numlock));
            case 301:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.CapsLock));
            case 302:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.ScrollLock));
            case 303:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.RightShift));
            case 304:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.LeftShift));
            case 305:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.RightControl));
            case 306:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.LeftControl));
            case 307:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.RightAlt));
            case 308:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.LeftAlt));
            case 309:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.RightApple));
            case 310:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.LeftApple));
            case 311:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.LeftWindows));
            case 312:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.RightWindows));
            case 313:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.AltGr));
            case 315:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Help));
            case 316:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Print));
            case 317:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.SysReq));
            case 318:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Break));
            case 319:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Menu));
            case 323:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Mouse0));
            case 324:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Mouse1));
            case 325:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Mouse2));
            case 326:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Mouse3));
            case 327:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Mouse4));
            case 328:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Mouse5));
            case 329:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Mouse6));
            case 330:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.JoystickButton0));
            case 331:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.JoystickButton1));
            case 332:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.JoystickButton2));
            case 333:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.JoystickButton3));
            case 334:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.JoystickButton4));
            case 335:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.JoystickButton5));
            case 336:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.JoystickButton6));
            case 337:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.JoystickButton7));
            case 338:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.JoystickButton8));
            case 339:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.JoystickButton9));
            case 340:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.JoystickButton10));
            case 341:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.JoystickButton11));
            case 342:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.JoystickButton12));
            case 343:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.JoystickButton13));
            case 344:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.JoystickButton14));
            case 345:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.JoystickButton15));
            case 346:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.JoystickButton16));
            case 347:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.JoystickButton17));
            case 348:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.JoystickButton18));
            case 349:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.JoystickButton19));
            case 350:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick1Button0));
            case 351:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick1Button1));
            case 352:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick1Button2));
            case 353:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick1Button3));
            case 354:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick1Button4));
            case 355:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick1Button5));
            case 356:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick1Button6));
            case 357:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick1Button7));
            case 358:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick1Button8));
            case 359:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick1Button9));
            case 360:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick1Button10));
            case 361:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick1Button11));
            case 362:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick1Button12));
            case 363:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick1Button13));
            case 364:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick1Button14));
            case 365:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick1Button15));
            case 366:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick1Button16));
            case 367:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick1Button17));
            case 368:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick1Button18));
            case 369:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick1Button19));
            case 370:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick2Button0));
            case 371:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick2Button1));
            case 372:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick2Button2));
            case 373:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick2Button3));
            case 374:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick2Button4));
            case 375:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick2Button5));
            case 376:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick2Button6));
            case 377:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick2Button7));
            case 378:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick2Button8));
            case 379:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick2Button9));
            case 380:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick2Button10));
            case 381:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick2Button11));
            case 382:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick2Button12));
            case 383:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick2Button13));
            case 384:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick2Button14));
            case 385:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick2Button15));
            case 386:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick2Button16));
            case 387:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick2Button17));
            case 388:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick2Button18));
            case 389:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick2Button19));
            case 390:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick3Button0));
            case 391:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick3Button1));
            case 392:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick3Button2));
            case 393:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick3Button3));
            case 394:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick3Button4));
            case 395:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick3Button5));
            case 396:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick3Button6));
            case 397:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick3Button7));
            case 398:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick3Button8));
            case 399:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick3Button9));
            case 400:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick3Button10));
            case 401:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick3Button11));
            case 402:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick3Button12));
            case 403:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick3Button13));
            case 404:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick3Button14));
            case 405:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick3Button15));
            case 406:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick3Button16));
            case 407:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick3Button17));
            case 408:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick3Button18));
            case 409:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick3Button19));
            case 410:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick4Button0));
            case 411:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick4Button1));
            case 412:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick4Button2));
            case 413:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick4Button3));
            case 414:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick4Button4));
            case 415:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick4Button5));
            case 416:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick4Button6));
            case 417:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick4Button7));
            case 418:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick4Button8));
            case 419:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick4Button9));
            case 420:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick4Button10));
            case 421:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick4Button11));
            case 422:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick4Button12));
            case 423:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick4Button13));
            case 424:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick4Button14));
            case 425:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick4Button15));
            case 426:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick4Button16));
            case 427:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick4Button17));
            case 428:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick4Button18));
            case 429:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick4Button19));
            case 430:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick5Button0));
            case 431:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick5Button1));
            case 432:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick5Button2));
            case 433:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick5Button3));
            case 434:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick5Button4));
            case 435:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick5Button5));
            case 436:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick5Button6));
            case 437:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick5Button7));
            case 438:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick5Button8));
            case 439:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick5Button9));
            case 440:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick5Button10));
            case 441:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick5Button11));
            case 442:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick5Button12));
            case 443:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick5Button13));
            case 444:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick5Button14));
            case 445:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick5Button15));
            case 446:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick5Button16));
            case 447:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick5Button17));
            case 448:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick5Button18));
            case 449:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick5Button19));
            case 450:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick6Button0));
            case 451:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick6Button1));
            case 452:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick6Button2));
            case 453:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick6Button3));
            case 454:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick6Button4));
            case 455:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick6Button5));
            case 456:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick6Button6));
            case 457:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick6Button7));
            case 458:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick6Button8));
            case 459:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick6Button9));
            case 460:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick6Button10));
            case 461:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick6Button11));
            case 462:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick6Button12));
            case 463:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick6Button13));
            case 464:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick6Button14));
            case 465:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick6Button15));
            case 466:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick6Button16));
            case 467:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick6Button17));
            case 468:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick6Button18));
            case 469:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick6Button19));
            case 470:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick7Button0));
            case 471:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick7Button1));
            case 472:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick7Button2));
            case 473:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick7Button3));
            case 474:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick7Button4));
            case 475:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick7Button5));
            case 476:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick7Button6));
            case 477:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick7Button7));
            case 478:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick7Button8));
            case 479:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick7Button9));
            case 480:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick7Button10));
            case 481:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick7Button11));
            case 482:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick7Button12));
            case 483:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick7Button13));
            case 484:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick7Button14));
            case 485:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick7Button15));
            case 486:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick7Button16));
            case 487:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick7Button17));
            case 488:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick7Button18));
            case 489:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick7Button19));
            case 490:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick8Button0));
            case 491:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick8Button1));
            case 492:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick8Button2));
            case 493:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick8Button3));
            case 494:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick8Button4));
            case 495:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick8Button5));
            case 496:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick8Button6));
            case 497:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick8Button7));
            case 498:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick8Button8));
            case 499:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick8Button9));
            case 500:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick8Button10));
            case 501:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick8Button11));
            case 502:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick8Button12));
            case 503:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick8Button13));
            case 504:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick8Button14));
            case 505:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick8Button15));
            case 506:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick8Button16));
            case 507:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick8Button17));
            case 508:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick8Button18));
            case 509:
                return Convert.ToInt32(Input.GetKeyDown(KeyCode.Joystick8Button19));
        }
        return 0.0f;
    }

    public static void SetInput(UI_Keybind keybind)
    {
        string _key = keybind.key;

        if (Input.anyKey)
        {
            if (Input.GetKey(KeyCode.Backspace))
            {
                PlayerPrefs.SetInt(_key, 8);
                
            }
            else if (Input.GetKey(KeyCode.Tab))
            {
                PlayerPrefs.SetInt(_key, 9);
                
            }
            else if (Input.GetKey(KeyCode.Clear))
            {
                PlayerPrefs.SetInt(_key, 12);
                
            }
            else if (Input.GetKey(KeyCode.Return))
            {
                PlayerPrefs.SetInt(_key, 13);
                
            }
            else if (Input.GetKey(KeyCode.Pause))
            {
                PlayerPrefs.SetInt(_key, 19);
                
            }
            else if (Input.GetKey(KeyCode.Escape))
            {
                PlayerPrefs.SetInt(_key, 27);
                
            }
            else if (Input.GetKey(KeyCode.Space))
            {
                PlayerPrefs.SetInt(_key, 32);
                
            }
            else if (Input.GetKey(KeyCode.Exclaim))
            {
                PlayerPrefs.SetInt(_key, 33);
                
            }
            else if (Input.GetKey(KeyCode.DoubleQuote))
            {
                PlayerPrefs.SetInt(_key, 34);
                
            }
            else if (Input.GetKey(KeyCode.Hash))
            {
                PlayerPrefs.SetInt(_key, 35);
                
            }
            else if (Input.GetKey(KeyCode.Dollar))
            {
                PlayerPrefs.SetInt(_key, 36);
                
            }
            else if (Input.GetKey(KeyCode.Percent))
            {
                PlayerPrefs.SetInt(_key, 37);
                
            }
            else if (Input.GetKey(KeyCode.Ampersand))
            {
                PlayerPrefs.SetInt(_key, 38);
                
            }
            else if (Input.GetKey(KeyCode.Quote))
            {
                PlayerPrefs.SetInt(_key, 39);
                
            }
            else if (Input.GetKey(KeyCode.LeftParen))
            {
                PlayerPrefs.SetInt(_key, 40);
                
            }
            else if (Input.GetKey(KeyCode.RightParen))
            {
                PlayerPrefs.SetInt(_key, 41);
                
            }
            else if (Input.GetKey(KeyCode.Asterisk))
            {
                PlayerPrefs.SetInt(_key, 42);
                
            }
            else if (Input.GetKey(KeyCode.Plus))
            {
                PlayerPrefs.SetInt(_key, 43);
                
            }
            else if (Input.GetKey(KeyCode.Comma))
            {
                PlayerPrefs.SetInt(_key, 44);
                
            }
            else if (Input.GetKey(KeyCode.Minus))
            {
                PlayerPrefs.SetInt(_key, 45);
                
            }
            else if (Input.GetKey(KeyCode.Period))
            {
                PlayerPrefs.SetInt(_key, 46);
                
            }
            else if (Input.GetKey(KeyCode.Slash))
            {
                PlayerPrefs.SetInt(_key, 47);
                
            }
            else if (Input.GetKey(KeyCode.Alpha0))
            {
                PlayerPrefs.SetInt(_key, 48);
                
            }
            else if (Input.GetKey(KeyCode.Alpha1))
            {
                PlayerPrefs.SetInt(_key, 49);
                
            }
            else if (Input.GetKey(KeyCode.Alpha2))
            {
                PlayerPrefs.SetInt(_key, 50);
                
            }
            else if (Input.GetKey(KeyCode.Alpha3))
            {
                PlayerPrefs.SetInt(_key, 51);
                
            }
            else if (Input.GetKey(KeyCode.Alpha4))
            {
                PlayerPrefs.SetInt(_key, 52);
                
            }
            else if (Input.GetKey(KeyCode.Alpha5))
            {
                PlayerPrefs.SetInt(_key, 53);
                
            }
            else if (Input.GetKey(KeyCode.Alpha6))
            {
                PlayerPrefs.SetInt(_key, 54);
                
            }
            else if (Input.GetKey(KeyCode.Alpha7))
            {
                PlayerPrefs.SetInt(_key, 55);
                
            }
            else if (Input.GetKey(KeyCode.Alpha8))
            {
                PlayerPrefs.SetInt(_key, 56);
                
            }
            else if (Input.GetKey(KeyCode.Alpha9))
            {
                PlayerPrefs.SetInt(_key, 57);
                
            }
            else if (Input.GetKey(KeyCode.Colon))
            {
                PlayerPrefs.SetInt(_key, 58);
                
            }
            else if (Input.GetKey(KeyCode.Semicolon))
            {
                PlayerPrefs.SetInt(_key, 59);
                
            }
            else if (Input.GetKey(KeyCode.Less))
            {
                PlayerPrefs.SetInt(_key, 60);
                
            }
            else if (Input.GetKey(KeyCode.Equals))
            {
                PlayerPrefs.SetInt(_key, 61);
                
            }
            else if (Input.GetKey(KeyCode.Greater))
            {
                PlayerPrefs.SetInt(_key, 62);
                
            }
            else if (Input.GetKey(KeyCode.Question))
            {
                PlayerPrefs.SetInt(_key, 63);
                
            }
            else if (Input.GetKey(KeyCode.At))
            {
                PlayerPrefs.SetInt(_key, 64);
                
            }
            else if (Input.GetKey(KeyCode.LeftBracket))
            {
                PlayerPrefs.SetInt(_key, 91);
                
            }
            else if (Input.GetKey(KeyCode.Backslash))
            {
                PlayerPrefs.SetInt(_key, 92);
                
            }
            else if (Input.GetKey(KeyCode.RightBracket))
            {
                PlayerPrefs.SetInt(_key, 93);
                
            }
            else if (Input.GetKey(KeyCode.Caret))
            {
                PlayerPrefs.SetInt(_key, 94);
                
            }
            else if (Input.GetKey(KeyCode.Underscore))
            {
                PlayerPrefs.SetInt(_key, 95);
                
            }
            else if (Input.GetKey(KeyCode.BackQuote))
            {
                PlayerPrefs.SetInt(_key, 96);
                
            }//END PRE LETTERS
            else if (Input.GetKey(KeyCode.A))
            {
                PlayerPrefs.SetInt(_key, 97);
                
            }
            else if (Input.GetKey(KeyCode.B))
            {
                PlayerPrefs.SetInt(_key, 98);
                
            }
            else if (Input.GetKey(KeyCode.C))
            {
                PlayerPrefs.SetInt(_key, 99);
                
            }
            else if (Input.GetKey(KeyCode.D))
            {
                PlayerPrefs.SetInt(_key, 100);
                
            }
            else if (Input.GetKey(KeyCode.E))
            {
                PlayerPrefs.SetInt(_key, 101);
                
            }
            else if (Input.GetKey(KeyCode.F))
            {
                PlayerPrefs.SetInt(_key, 102);
                
            }
            else if (Input.GetKey(KeyCode.G))
            {
                PlayerPrefs.SetInt(_key, 103);
                
            }
            else if (Input.GetKey(KeyCode.H))
            {
                PlayerPrefs.SetInt(_key, 104);
                
            }
            else if (Input.GetKey(KeyCode.I))
            {
                PlayerPrefs.SetInt(_key, 105);
                
            }
            else if (Input.GetKey(KeyCode.J))
            {
                PlayerPrefs.SetInt(_key, 106);
                
            }
            else if (Input.GetKey(KeyCode.K))
            {
                PlayerPrefs.SetInt(_key, 107);
                
            }
            else if (Input.GetKey(KeyCode.L))
            {
                PlayerPrefs.SetInt(_key, 108);
                
            }
            else if (Input.GetKey(KeyCode.M))
            {
                PlayerPrefs.SetInt(_key, 109);
                
            }
            else if (Input.GetKey(KeyCode.N))
            {
                PlayerPrefs.SetInt(_key, 110);
                
            }
            else if (Input.GetKey(KeyCode.O))
            {
                PlayerPrefs.SetInt(_key, 111);
                
            }
            else if (Input.GetKey(KeyCode.P))
            {
                PlayerPrefs.SetInt(_key, 112);
                
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                PlayerPrefs.SetInt(_key, 113);
                
            }
            else if (Input.GetKey(KeyCode.R))
            {
                PlayerPrefs.SetInt(_key, 114);
                
            }
            else if (Input.GetKey(KeyCode.S))
            {
                PlayerPrefs.SetInt(_key, 115);
                
            }
            else if (Input.GetKey(KeyCode.T))
            {
                PlayerPrefs.SetInt(_key, 116);
                
            }
            else if (Input.GetKey(KeyCode.U))
            {
                PlayerPrefs.SetInt(_key, 117);
                
            }
            else if (Input.GetKey(KeyCode.V))
            {
                PlayerPrefs.SetInt(_key, 118);
                
            }
            else if (Input.GetKey(KeyCode.W))
            {
                PlayerPrefs.SetInt(_key, 119);
                
            }
            else if (Input.GetKey(KeyCode.X))
            {
                PlayerPrefs.SetInt(_key, 120);
                
            }
            else if (Input.GetKey(KeyCode.Y))
            {
                PlayerPrefs.SetInt(_key, 121);
                
            }
            else if (Input.GetKey(KeyCode.Z))
            {
                PlayerPrefs.SetInt(_key, 122);
                
            }//END LETTERS
            else if (Input.GetKey(KeyCode.LeftCurlyBracket))
            {
                PlayerPrefs.SetInt(_key, 123);
                
            }
            else if (Input.GetKey(KeyCode.Pipe))
            {
                PlayerPrefs.SetInt(_key, 124);
                
            }
            else if (Input.GetKey(KeyCode.RightCurlyBracket))
            {
                PlayerPrefs.SetInt(_key, 125);
                
            }
            else if (Input.GetKey(KeyCode.Tilde))
            {
                PlayerPrefs.SetInt(_key, 126);
                
            }
            else if (Input.GetKey(KeyCode.Delete))
            {
                PlayerPrefs.SetInt(_key, 127);
                
            }
            else if (Input.GetKey(KeyCode.Keypad0))
            {
                PlayerPrefs.SetInt(_key, 256);
                
            }
            else if (Input.GetKey(KeyCode.Keypad1))
            {
                PlayerPrefs.SetInt(_key, 257);
                
            }
            else if (Input.GetKey(KeyCode.Keypad2))
            {
                PlayerPrefs.SetInt(_key, 258);
                
            }
            else if (Input.GetKey(KeyCode.Keypad3))
            {
                PlayerPrefs.SetInt(_key, 259);
                
            }
            else if (Input.GetKey(KeyCode.Keypad4))
            {
                PlayerPrefs.SetInt(_key, 260);
                
            }
            else if (Input.GetKey(KeyCode.Keypad5))
            {
                PlayerPrefs.SetInt(_key, 261);
                
            }
            else if (Input.GetKey(KeyCode.Keypad6))
            {
                PlayerPrefs.SetInt(_key, 262);
                
            }
            else if (Input.GetKey(KeyCode.Keypad7))
            {
                PlayerPrefs.SetInt(_key, 263);
                
            }
            else if (Input.GetKey(KeyCode.Keypad8))
            {
                PlayerPrefs.SetInt(_key, 264);
                
            }
            else if (Input.GetKey(KeyCode.Keypad9))
            {
                PlayerPrefs.SetInt(_key, 265);
                
            }
            else if (Input.GetKey(KeyCode.KeypadPeriod))
            {
                PlayerPrefs.SetInt(_key, 266);
                
            }
            else if (Input.GetKey(KeyCode.KeypadDivide))
            {
                PlayerPrefs.SetInt(_key, 267);
                
            }
            else if (Input.GetKey(KeyCode.KeypadMultiply))
            {
                PlayerPrefs.SetInt(_key, 268);
                
            }
            else if (Input.GetKey(KeyCode.KeypadMinus))
            {
                PlayerPrefs.SetInt(_key, 269);
                
            }
            else if (Input.GetKey(KeyCode.KeypadPlus))
            {
                PlayerPrefs.SetInt(_key, 270);
                
            }
            else if (Input.GetKey(KeyCode.KeypadEnter))
            {
                PlayerPrefs.SetInt(_key, 271);
                
            }
            else if (Input.GetKey(KeyCode.KeypadEquals))
            {
                PlayerPrefs.SetInt(_key, 272);
                
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                PlayerPrefs.SetInt(_key, 273);
                
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                PlayerPrefs.SetInt(_key, 274);
                
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                PlayerPrefs.SetInt(_key, 275);
                
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                PlayerPrefs.SetInt(_key, 276);
                
            }
            else if (Input.GetKey(KeyCode.Insert))
            {
                PlayerPrefs.SetInt(_key, 277);
                
            }
            else if (Input.GetKey(KeyCode.Home))
            {
                PlayerPrefs.SetInt(_key, 278);
                
            }
            else if (Input.GetKey(KeyCode.End))
            {
                PlayerPrefs.SetInt(_key, 279);
                
            }
            else if (Input.GetKey(KeyCode.PageUp))
            {
                PlayerPrefs.SetInt(_key, 280);
                
            }
            else if (Input.GetKey(KeyCode.PageDown))
            {
                PlayerPrefs.SetInt(_key, 281);
                
            }
            else if (Input.GetKey(KeyCode.F1))
            {
                PlayerPrefs.SetInt(_key, 272);
                
            }
            else if (Input.GetKey(KeyCode.F2))
            {
                PlayerPrefs.SetInt(_key, 273);
                
            }
            else if (Input.GetKey(KeyCode.F3))
            {
                PlayerPrefs.SetInt(_key, 274);
                
            }
            else if (Input.GetKey(KeyCode.F4))
            {
                PlayerPrefs.SetInt(_key, 275);
                
            }
            else if (Input.GetKey(KeyCode.F5))
            {
                PlayerPrefs.SetInt(_key, 276);
                
            }
            else if (Input.GetKey(KeyCode.F6))
            {
                PlayerPrefs.SetInt(_key, 277);
                
            }
            else if (Input.GetKey(KeyCode.F7))
            {
                PlayerPrefs.SetInt(_key, 278);
                
            }
            else if (Input.GetKey(KeyCode.F8))
            {
                PlayerPrefs.SetInt(_key, 279);
                
            }
            else if (Input.GetKey(KeyCode.F9))
            {
                PlayerPrefs.SetInt(_key, 290);
                
            }
            else if (Input.GetKey(KeyCode.F10))
            {
                PlayerPrefs.SetInt(_key, 291);
                
            }
            else if (Input.GetKey(KeyCode.F11))
            {
                PlayerPrefs.SetInt(_key, 292);
                
            }
            else if (Input.GetKey(KeyCode.F12))
            {
                PlayerPrefs.SetInt(_key, 293);
                
            }
            else if (Input.GetKey(KeyCode.F13))
            {
                PlayerPrefs.SetInt(_key, 294);
                
            }
            else if (Input.GetKey(KeyCode.F14))
            {
                PlayerPrefs.SetInt(_key, 295);
                
            }
            else if (Input.GetKey(KeyCode.F15))
            {
                PlayerPrefs.SetInt(_key, 296);
                
            }
            else if (Input.GetKey(KeyCode.Numlock))
            {
                PlayerPrefs.SetInt(_key, 300);
                
            }
            else if (Input.GetKey(KeyCode.CapsLock))
            {
                PlayerPrefs.SetInt(_key, 301);
                
            }
            else if (Input.GetKey(KeyCode.ScrollLock))
            {
                PlayerPrefs.SetInt(_key, 302);
                
            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                PlayerPrefs.SetInt(_key, 303);
                
            }
            else if (Input.GetKey(KeyCode.LeftShift))
            {
                PlayerPrefs.SetInt(_key, 304);
                
            }
            else if (Input.GetKey(KeyCode.RightControl))
            {
                PlayerPrefs.SetInt(_key, 305);
                
            }
            else if (Input.GetKey(KeyCode.LeftControl))
            {
                PlayerPrefs.SetInt(_key, 306);
                
            }
            else if (Input.GetKey(KeyCode.RightAlt))
            {
                PlayerPrefs.SetInt(_key, 307);
                
            }
            else if (Input.GetKey(KeyCode.LeftAlt))
            {
                PlayerPrefs.SetInt(_key, 308);
                
            }
            else if (Input.GetKey(KeyCode.RightCommand))
            {
                PlayerPrefs.SetInt(_key, 309);
                
            }
            else if (Input.GetKey(KeyCode.LeftCommand))
            {
                PlayerPrefs.SetInt(_key, 310);
                
            }
            else if (Input.GetKey(KeyCode.LeftWindows))
            {
                PlayerPrefs.SetInt(_key, 311);
                
            }
            else if (Input.GetKey(KeyCode.RightWindows))
            {
                PlayerPrefs.SetInt(_key, 312);
                
            }
            else if (Input.GetKey(KeyCode.AltGr))
            {
                PlayerPrefs.SetInt(_key, 313);
                
            }
            else if (Input.GetKey(KeyCode.Help))
            {
                PlayerPrefs.SetInt(_key, 315);
                
            }
            else if (Input.GetKey(KeyCode.Print))
            {
                PlayerPrefs.SetInt(_key, 316);
                
            }
            else if (Input.GetKey(KeyCode.SysReq))
            {
                PlayerPrefs.SetInt(_key, 317);
                
            }
            else if (Input.GetKey(KeyCode.Break))
            {
                PlayerPrefs.SetInt(_key, 318);
                
            }
            else if (Input.GetKey(KeyCode.Menu))
            {
                PlayerPrefs.SetInt(_key, 319);
                
            }
            else if (Input.GetKey(KeyCode.Mouse0))
            {
                PlayerPrefs.SetInt(_key, 323);
                
            }
            else if (Input.GetKey(KeyCode.Mouse1))
            {
                PlayerPrefs.SetInt(_key, 324);
                
            }
            else if (Input.GetKey(KeyCode.Mouse2))
            {
                PlayerPrefs.SetInt(_key, 325);
                
            }
            else if (Input.GetKey(KeyCode.Mouse3))
            {
                PlayerPrefs.SetInt(_key, 326);
                
            }
            else if (Input.GetKey(KeyCode.Mouse4))
            {
                PlayerPrefs.SetInt(_key, 327);
                
            }
            else if (Input.GetKey(KeyCode.Mouse5))
            {
                PlayerPrefs.SetInt(_key, 328);
                
            }
            else if (Input.GetKey(KeyCode.Mouse6))
            {
                PlayerPrefs.SetInt(_key, 329);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton0))
            {
                PlayerPrefs.SetInt(_key, 330);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton1))
            {
                PlayerPrefs.SetInt(_key, 331);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton2))
            {
                PlayerPrefs.SetInt(_key, 332);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton3))
            {
                PlayerPrefs.SetInt(_key, 333);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton4))
            {
                PlayerPrefs.SetInt(_key, 334);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton5))
            {
                PlayerPrefs.SetInt(_key, 335);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton6))
            {
                PlayerPrefs.SetInt(_key, 336);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton7))
            {
                PlayerPrefs.SetInt(_key, 337);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton8))
            {
                PlayerPrefs.SetInt(_key, 338);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton9))
            {
                PlayerPrefs.SetInt(_key, 339);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton10))
            {
                PlayerPrefs.SetInt(_key, 340);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton11))
            {
                PlayerPrefs.SetInt(_key, 341);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton12))
            {
                PlayerPrefs.SetInt(_key, 342);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton13))
            {
                PlayerPrefs.SetInt(_key, 343);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton14))
            {
                PlayerPrefs.SetInt(_key, 344);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton15))
            {
                PlayerPrefs.SetInt(_key, 345);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton16))
            {
                PlayerPrefs.SetInt(_key, 346);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton17))
            {
                PlayerPrefs.SetInt(_key, 347);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton18))
            {
                PlayerPrefs.SetInt(_key, 348);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton19))
            {
                PlayerPrefs.SetInt(_key, 349);
                
            }
            else if (Input.GetKey(KeyCode.JoystickButton0))
            {
                PlayerPrefs.SetInt(_key, 330);
                
            }
            else if (Input.GetKey(KeyCode.Joystick1Button1))
            {
                PlayerPrefs.SetInt(_key, 351);
                
            }
            else if (Input.GetKey(KeyCode.Joystick1Button2))
            {
                PlayerPrefs.SetInt(_key, 352);
                
            }
            else if (Input.GetKey(KeyCode.Joystick1Button3))
            {
                PlayerPrefs.SetInt(_key, 353);
                
            }
            else if (Input.GetKey(KeyCode.Joystick1Button4))
            {
                PlayerPrefs.SetInt(_key, 354);
                
            }
            else if (Input.GetKey(KeyCode.Joystick1Button5))
            {
                PlayerPrefs.SetInt(_key, 355);
                
            }
            else if (Input.GetKey(KeyCode.Joystick1Button6))
            {
                PlayerPrefs.SetInt(_key, 356);
                
            }
            else if (Input.GetKey(KeyCode.Joystick1Button7))
            {
                PlayerPrefs.SetInt(_key, 357);
                
            }
            else if (Input.GetKey(KeyCode.Joystick1Button8))
            {
                PlayerPrefs.SetInt(_key, 358);
                
            }
            else if (Input.GetKey(KeyCode.Joystick1Button9))
            {
                PlayerPrefs.SetInt(_key, 359);
                
            }
            else if (Input.GetKey(KeyCode.Joystick1Button10))
            {
                PlayerPrefs.SetInt(_key, 360);
                
            }
            else if (Input.GetKey(KeyCode.Joystick1Button11))
            {
                PlayerPrefs.SetInt(_key, 361);
                
            }
            else if (Input.GetKey(KeyCode.Joystick1Button12))
            {
                PlayerPrefs.SetInt(_key, 362);
                
            }
            else if (Input.GetKey(KeyCode.Joystick1Button13))
            {
                PlayerPrefs.SetInt(_key, 363);
                
            }
            else if (Input.GetKey(KeyCode.Joystick1Button14))
            {
                PlayerPrefs.SetInt(_key, 364);
                
            }
            else if (Input.GetKey(KeyCode.Joystick1Button15))
            {
                PlayerPrefs.SetInt(_key, 365);
                
            }
            else if (Input.GetKey(KeyCode.Joystick1Button16))
            {
                PlayerPrefs.SetInt(_key, 366);
                
            }
            else if (Input.GetKey(KeyCode.Joystick1Button17))
            {
                PlayerPrefs.SetInt(_key, 367);
                
            }
            else if (Input.GetKey(KeyCode.Joystick1Button18))
            {
                PlayerPrefs.SetInt(_key, 368);
                
            }
            else if (Input.GetKey(KeyCode.Joystick1Button19))
            {
                PlayerPrefs.SetInt(_key, 369);
                
            }
            else if (Input.GetKey(KeyCode.Joystick2Button0))
            {
                PlayerPrefs.SetInt(_key, 370);
                
            }
            else if (Input.GetKey(KeyCode.Joystick2Button1))
            {
                PlayerPrefs.SetInt(_key, 371);
                
            }
            else if (Input.GetKey(KeyCode.Joystick2Button2))
            {
                PlayerPrefs.SetInt(_key, 372);
                
            }
            else if (Input.GetKey(KeyCode.Joystick2Button3))
            {
                PlayerPrefs.SetInt(_key, 373);
                
            }
            else if (Input.GetKey(KeyCode.Joystick2Button4))
            {
                PlayerPrefs.SetInt(_key, 374);
                
            }
            else if (Input.GetKey(KeyCode.Joystick2Button5))
            {
                PlayerPrefs.SetInt(_key, 375);
                
            }
            else if (Input.GetKey(KeyCode.Joystick2Button6))
            {
                PlayerPrefs.SetInt(_key, 376);
                
            }
            else if (Input.GetKey(KeyCode.Joystick2Button7))
            {
                PlayerPrefs.SetInt(_key, 377);
                
            }
            else if (Input.GetKey(KeyCode.Joystick2Button8))
            {
                PlayerPrefs.SetInt(_key, 378);
                
            }
            else if (Input.GetKey(KeyCode.Joystick2Button9))
            {
                PlayerPrefs.SetInt(_key, 379);
                
            }
            else if (Input.GetKey(KeyCode.Joystick2Button10))
            {
                PlayerPrefs.SetInt(_key, 380);
                
            }
            else if (Input.GetKey(KeyCode.Joystick2Button11))
            {
                PlayerPrefs.SetInt(_key, 381);
                
            }
            else if (Input.GetKey(KeyCode.Joystick2Button12))
            {
                PlayerPrefs.SetInt(_key, 382);
                
            }
            else if (Input.GetKey(KeyCode.Joystick2Button13))
            {
                PlayerPrefs.SetInt(_key, 383);
                
            }
            else if (Input.GetKey(KeyCode.Joystick2Button14))
            {
                PlayerPrefs.SetInt(_key, 384);
                
            }
            else if (Input.GetKey(KeyCode.Joystick2Button15))
            {
                PlayerPrefs.SetInt(_key, 385);
                
            }
            else if (Input.GetKey(KeyCode.Joystick2Button16))
            {
                PlayerPrefs.SetInt(_key, 386);
                
            }
            else if (Input.GetKey(KeyCode.Joystick2Button17))
            {
                PlayerPrefs.SetInt(_key, 387);
                
            }
            else if (Input.GetKey(KeyCode.Joystick2Button18))
            {
                PlayerPrefs.SetInt(_key, 388);
                
            }
            else if (Input.GetKey(KeyCode.Joystick2Button19))
            {
                PlayerPrefs.SetInt(_key, 389);
                
            }
            else if (Input.GetKey(KeyCode.Joystick3Button0))
            {
                PlayerPrefs.SetInt(_key, 390);
                
            }
            else if (Input.GetKey(KeyCode.Joystick3Button1))
            {
                PlayerPrefs.SetInt(_key, 391);
                
            }
            else if (Input.GetKey(KeyCode.Joystick3Button2))
            {
                PlayerPrefs.SetInt(_key, 392);
                
            }
            else if (Input.GetKey(KeyCode.Joystick3Button3))
            {
                PlayerPrefs.SetInt(_key, 393);
                
            }
            else if (Input.GetKey(KeyCode.Joystick3Button4))
            {
                PlayerPrefs.SetInt(_key, 394);
                
            }
            else if (Input.GetKey(KeyCode.Joystick3Button5))
            {
                PlayerPrefs.SetInt(_key, 395);
                
            }
            else if (Input.GetKey(KeyCode.Joystick3Button6))
            {
                PlayerPrefs.SetInt(_key, 396);
                
            }
            else if (Input.GetKey(KeyCode.Joystick3Button7))
            {
                PlayerPrefs.SetInt(_key, 397);
                
            }
            else if (Input.GetKey(KeyCode.Joystick3Button8))
            {
                PlayerPrefs.SetInt(_key, 398);
                
            }
            else if (Input.GetKey(KeyCode.Joystick3Button9))
            {
                PlayerPrefs.SetInt(_key, 399);
                
            }
            else if (Input.GetKey(KeyCode.Joystick3Button10))
            {
                PlayerPrefs.SetInt(_key, 400);
                
            }
            else if (Input.GetKey(KeyCode.Joystick3Button11))
            {
                PlayerPrefs.SetInt(_key, 401);
                
            }
            else if (Input.GetKey(KeyCode.Joystick3Button12))
            {
                PlayerPrefs.SetInt(_key, 402);
                
            }
            else if (Input.GetKey(KeyCode.Joystick3Button13))
            {
                PlayerPrefs.SetInt(_key, 403);
                
            }
            else if (Input.GetKey(KeyCode.Joystick3Button14))
            {
                PlayerPrefs.SetInt(_key, 404);
                
            }
            else if (Input.GetKey(KeyCode.Joystick3Button15))
            {
                PlayerPrefs.SetInt(_key, 405);
                
            }
            else if (Input.GetKey(KeyCode.Joystick3Button16))
            {
                PlayerPrefs.SetInt(_key, 406);
                
            }
            else if (Input.GetKey(KeyCode.Joystick3Button17))
            {
                PlayerPrefs.SetInt(_key, 407);
                
            }
            else if (Input.GetKey(KeyCode.Joystick3Button18))
            {
                PlayerPrefs.SetInt(_key, 408);
                
            }
            else if (Input.GetKey(KeyCode.Joystick3Button19))
            {
                PlayerPrefs.SetInt(_key, 409);
                
            }
            else if (Input.GetKey(KeyCode.Joystick4Button0))
            {
                PlayerPrefs.SetInt(_key, 410);
                
            }
            else if (Input.GetKey(KeyCode.Joystick4Button1))
            {
                PlayerPrefs.SetInt(_key, 411);
                
            }
            else if (Input.GetKey(KeyCode.Joystick4Button2))
            {
                PlayerPrefs.SetInt(_key, 412);
                
            }
            else if (Input.GetKey(KeyCode.Joystick4Button3))
            {
                PlayerPrefs.SetInt(_key, 413);
                
            }
            else if (Input.GetKey(KeyCode.Joystick4Button4))
            {
                PlayerPrefs.SetInt(_key, 414);
                
            }
            else if (Input.GetKey(KeyCode.Joystick4Button5))
            {
                PlayerPrefs.SetInt(_key, 415);
                
            }
            else if (Input.GetKey(KeyCode.Joystick4Button6))
            {
                PlayerPrefs.SetInt(_key, 416);
                
            }
            else if (Input.GetKey(KeyCode.Joystick4Button7))
            {
                PlayerPrefs.SetInt(_key, 417);
                
            }
            else if (Input.GetKey(KeyCode.Joystick4Button8))
            {
                PlayerPrefs.SetInt(_key, 418);
                
            }
            else if (Input.GetKey(KeyCode.Joystick4Button9))
            {
                PlayerPrefs.SetInt(_key, 419);
                
            }
            else if (Input.GetKey(KeyCode.Joystick4Button10))
            {
                PlayerPrefs.SetInt(_key, 420);
                
            }
            else if (Input.GetKey(KeyCode.Joystick4Button11))
            {
                PlayerPrefs.SetInt(_key, 421);
                
            }
            else if (Input.GetKey(KeyCode.Joystick4Button12))
            {
                PlayerPrefs.SetInt(_key, 422);
                
            }
            else if (Input.GetKey(KeyCode.Joystick4Button13))
            {
                PlayerPrefs.SetInt(_key, 423);
                
            }
            else if (Input.GetKey(KeyCode.Joystick4Button14))
            {
                PlayerPrefs.SetInt(_key, 424);
                
            }
            else if (Input.GetKey(KeyCode.Joystick4Button15))
            {
                PlayerPrefs.SetInt(_key, 425);
                
            }
            else if (Input.GetKey(KeyCode.Joystick4Button16))
            {
                PlayerPrefs.SetInt(_key, 426);
                
            }
            else if (Input.GetKey(KeyCode.Joystick4Button17))
            {
                PlayerPrefs.SetInt(_key, 427);
                
            }
            else if (Input.GetKey(KeyCode.Joystick4Button18))
            {
                PlayerPrefs.SetInt(_key, 428);
                
            }
            else if (Input.GetKey(KeyCode.Joystick4Button19))
            {
                PlayerPrefs.SetInt(_key, 429);
                
            }
            else if (Input.GetKey(KeyCode.Joystick5Button0))
            {
                PlayerPrefs.SetInt(_key, 430);
                
            }
            else if (Input.GetKey(KeyCode.Joystick5Button1))
            {
                PlayerPrefs.SetInt(_key, 431);
                
            }
            else if (Input.GetKey(KeyCode.Joystick5Button2))
            {
                PlayerPrefs.SetInt(_key, 432);
                
            }
            else if (Input.GetKey(KeyCode.Joystick5Button3))
            {
                PlayerPrefs.SetInt(_key, 433);
                
            }
            else if (Input.GetKey(KeyCode.Joystick5Button4))
            {
                PlayerPrefs.SetInt(_key, 434);
                
            }
            else if (Input.GetKey(KeyCode.Joystick5Button5))
            {
                PlayerPrefs.SetInt(_key, 435);
                
            }
            else if (Input.GetKey(KeyCode.Joystick5Button6))
            {
                PlayerPrefs.SetInt(_key, 436);
                
            }
            else if (Input.GetKey(KeyCode.Joystick5Button7))
            {
                PlayerPrefs.SetInt(_key, 437);
                
            }
            else if (Input.GetKey(KeyCode.Joystick5Button8))
            {
                PlayerPrefs.SetInt(_key, 438);
                
            }
            else if (Input.GetKey(KeyCode.Joystick5Button9))
            {
                PlayerPrefs.SetInt(_key, 439);
                
            }
            else if (Input.GetKey(KeyCode.Joystick5Button10))
            {
                PlayerPrefs.SetInt(_key, 440);
                
            }
            else if (Input.GetKey(KeyCode.Joystick5Button11))
            {
                PlayerPrefs.SetInt(_key, 441);
                
            }
            else if (Input.GetKey(KeyCode.Joystick5Button12))
            {
                PlayerPrefs.SetInt(_key, 442);
                
            }
            else if (Input.GetKey(KeyCode.Joystick5Button13))
            {
                PlayerPrefs.SetInt(_key, 443);
                
            }
            else if (Input.GetKey(KeyCode.Joystick5Button14))
            {
                PlayerPrefs.SetInt(_key, 444);
                
            }
            else if (Input.GetKey(KeyCode.Joystick5Button15))
            {
                PlayerPrefs.SetInt(_key, 445);
                
            }
            else if (Input.GetKey(KeyCode.Joystick5Button16))
            {
                PlayerPrefs.SetInt(_key, 446);
                
            }
            else if (Input.GetKey(KeyCode.Joystick5Button17))
            {
                PlayerPrefs.SetInt(_key, 447);
                
            }
            else if (Input.GetKey(KeyCode.Joystick5Button18))
            {
                PlayerPrefs.SetInt(_key, 448);
                
            }
            else if (Input.GetKey(KeyCode.Joystick5Button19))
            {
                PlayerPrefs.SetInt(_key, 449);
                
            }
            else if (Input.GetKey(KeyCode.Joystick6Button0))
            {
                PlayerPrefs.SetInt(_key, 450);
                
            }
            else if (Input.GetKey(KeyCode.Joystick6Button1))
            {
                PlayerPrefs.SetInt(_key, 451);
                
            }
            else if (Input.GetKey(KeyCode.Joystick6Button2))
            {
                PlayerPrefs.SetInt(_key, 452);
                
            }
            else if (Input.GetKey(KeyCode.Joystick6Button3))
            {
                PlayerPrefs.SetInt(_key, 453);
                
            }
            else if (Input.GetKey(KeyCode.Joystick6Button4))
            {
                PlayerPrefs.SetInt(_key, 454);
                
            }
            else if (Input.GetKey(KeyCode.Joystick6Button5))
            {
                PlayerPrefs.SetInt(_key, 455);
                
            }
            else if (Input.GetKey(KeyCode.Joystick6Button6))
            {
                PlayerPrefs.SetInt(_key, 456);
                
            }
            else if (Input.GetKey(KeyCode.Joystick6Button7))
            {
                PlayerPrefs.SetInt(_key, 457);
                
            }
            else if (Input.GetKey(KeyCode.Joystick6Button8))
            {
                PlayerPrefs.SetInt(_key, 458);
                
            }
            else if (Input.GetKey(KeyCode.Joystick6Button9))
            {
                PlayerPrefs.SetInt(_key, 459);
                
            }
            else if (Input.GetKey(KeyCode.Joystick6Button10))
            {
                PlayerPrefs.SetInt(_key, 460);
                
            }
            else if (Input.GetKey(KeyCode.Joystick6Button11))
            {
                PlayerPrefs.SetInt(_key, 461);
                
            }
            else if (Input.GetKey(KeyCode.Joystick6Button12))
            {
                PlayerPrefs.SetInt(_key, 462);
                
            }
            else if (Input.GetKey(KeyCode.Joystick6Button13))
            {
                PlayerPrefs.SetInt(_key, 463);
                
            }
            else if (Input.GetKey(KeyCode.Joystick6Button14))
            {
                PlayerPrefs.SetInt(_key, 464);
                
            }
            else if (Input.GetKey(KeyCode.Joystick6Button15))
            {
                PlayerPrefs.SetInt(_key, 465);
                
            }
            else if (Input.GetKey(KeyCode.Joystick6Button16))
            {
                PlayerPrefs.SetInt(_key, 466);
                
            }
            else if (Input.GetKey(KeyCode.Joystick6Button17))
            {
                PlayerPrefs.SetInt(_key, 467);
                
            }
            else if (Input.GetKey(KeyCode.Joystick6Button18))
            {
                PlayerPrefs.SetInt(_key, 468);
                
            }
            else if (Input.GetKey(KeyCode.Joystick6Button19))
            {
                PlayerPrefs.SetInt(_key, 469);
                
            }
            else if (Input.GetKey(KeyCode.Joystick7Button0))
            {
                PlayerPrefs.SetInt(_key, 470);
                
            }
            else if (Input.GetKey(KeyCode.Joystick7Button1))
            {
                PlayerPrefs.SetInt(_key, 471);
                
            }
            else if (Input.GetKey(KeyCode.Joystick7Button2))
            {
                PlayerPrefs.SetInt(_key, 472);
                
            }
            else if (Input.GetKey(KeyCode.Joystick7Button3))
            {
                PlayerPrefs.SetInt(_key, 473);
                
            }
            else if (Input.GetKey(KeyCode.Joystick7Button4))
            {
                PlayerPrefs.SetInt(_key, 474);
            }
            else if (Input.GetKey(KeyCode.Joystick7Button5))
            {
                PlayerPrefs.SetInt(_key, 475);
            }
            else if (Input.GetKey(KeyCode.Joystick7Button6))
            {
                PlayerPrefs.SetInt(_key, 476);
            }
            else if (Input.GetKey(KeyCode.Joystick7Button7))
            {
                PlayerPrefs.SetInt(_key, 477);
            }
            else if (Input.GetKey(KeyCode.Joystick7Button8))
            {
                PlayerPrefs.SetInt(_key, 478);
            }
            else if (Input.GetKey(KeyCode.Joystick7Button9))
            {
                PlayerPrefs.SetInt(_key, 479);
            }
            else if (Input.GetKey(KeyCode.Joystick7Button10))
            {
                PlayerPrefs.SetInt(_key, 480);
            }
            else if (Input.GetKey(KeyCode.Joystick7Button11))
            {
                PlayerPrefs.SetInt(_key, 481);
            }
            else if (Input.GetKey(KeyCode.Joystick7Button12))
            {
                PlayerPrefs.SetInt(_key, 482);
            }
            else if (Input.GetKey(KeyCode.Joystick7Button13))
            {
                PlayerPrefs.SetInt(_key, 483);
            }
            else if (Input.GetKey(KeyCode.Joystick7Button14))
            {
                PlayerPrefs.SetInt(_key, 484);
            }
            else if (Input.GetKey(KeyCode.Joystick7Button15))
            {
                PlayerPrefs.SetInt(_key, 485);
            }
            else if (Input.GetKey(KeyCode.Joystick7Button16))
            {
                PlayerPrefs.SetInt(_key, 486);
            }
            else if (Input.GetKey(KeyCode.Joystick7Button17))
            {
                PlayerPrefs.SetInt(_key, 487);
            }
            else if (Input.GetKey(KeyCode.Joystick7Button18))
            {
                PlayerPrefs.SetInt(_key, 488);
            }
            else if (Input.GetKey(KeyCode.Joystick7Button19))
            {
                PlayerPrefs.SetInt(_key, 489);
            }
            else if (Input.GetKey(KeyCode.Joystick8Button0))
            {
                PlayerPrefs.SetInt(_key, 490);
            }
            else if (Input.GetKey(KeyCode.Joystick8Button1))
            {
                PlayerPrefs.SetInt(_key, 491);
            }
            else if (Input.GetKey(KeyCode.Joystick8Button2))
            {
                PlayerPrefs.SetInt(_key, 492);
            }
            else if (Input.GetKey(KeyCode.Joystick8Button3))
            {
                PlayerPrefs.SetInt(_key, 493);
            }
            else if (Input.GetKey(KeyCode.Joystick8Button4))
            {
                PlayerPrefs.SetInt(_key, 494);
            }
            else if (Input.GetKey(KeyCode.Joystick8Button5))
            {
                PlayerPrefs.SetInt(_key, 495);
            }
            else if (Input.GetKey(KeyCode.Joystick8Button6))
            {
                PlayerPrefs.SetInt(_key, 496);
                
            }
            else if (Input.GetKey(KeyCode.Joystick8Button7))
            {
                PlayerPrefs.SetInt(_key, 497);
            }
            else if (Input.GetKey(KeyCode.Joystick8Button8))
            {
                PlayerPrefs.SetInt(_key, 498);
            }
            else if (Input.GetKey(KeyCode.Joystick8Button9))
            {
                PlayerPrefs.SetInt(_key, 499);
            }
            else if (Input.GetKey(KeyCode.Joystick8Button10))
            {
                PlayerPrefs.SetInt(_key, 500);
            }
            else if (Input.GetKey(KeyCode.Joystick8Button11))
            {
                PlayerPrefs.SetInt(_key, 501);
            }
            else if (Input.GetKey(KeyCode.Joystick8Button12))
            {
                PlayerPrefs.SetInt(_key, 502);
            }
            else if (Input.GetKey(KeyCode.Joystick8Button13))
            {
                PlayerPrefs.SetInt(_key, 503);
            }
            else if (Input.GetKey(KeyCode.Joystick8Button14))
            {
                PlayerPrefs.SetInt(_key, 504);
            }
            else if (Input.GetKey(KeyCode.Joystick8Button15))
            {
                PlayerPrefs.SetInt(_key, 505);
            }
            else if (Input.GetKey(KeyCode.Joystick8Button16))
            {
                PlayerPrefs.SetInt(_key, 506);
            }
            else if (Input.GetKey(KeyCode.Joystick8Button17))
            {
                PlayerPrefs.SetInt(_key, 507);
            }
            else if (Input.GetKey(KeyCode.Joystick8Button18))
            {
                PlayerPrefs.SetInt(_key, 508);
            }
            else if (Input.GetKey(KeyCode.Joystick8Button19))
            {
                PlayerPrefs.SetInt(_key, 509);
            }
        }

        string bindName = ((KeyCode)PlayerPrefs.GetInt(_key)).ToString();
        keybind.buttonText.text = bindName;
    }
}
