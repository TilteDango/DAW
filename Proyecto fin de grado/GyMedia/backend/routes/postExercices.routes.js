import { Router } from "express";
import * as PostExreciceCtrl from "../controllers/postExercices.controllers.js";
import ExercicieUploadMiddleware from "../middlewares/Uploads/exerciciePost.js";

const router = Router();

router.post(
  "/create",
  ExercicieUploadMiddleware,
  PostExreciceCtrl.createExercicie
);
router.post("/byId", PostExreciceCtrl.getExercicesById);
router.post("/byToken", PostExreciceCtrl.getExercicesByToken);
router.get("/", PostExreciceCtrl.getExercices);

export default router;
