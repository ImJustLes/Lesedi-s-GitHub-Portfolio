package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.controller;

import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model.DisposalGuideline;
import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.repo.DisposalGuidelineRepo;
import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service.APIService;
import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service.CleanUpService;
import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service.DisposalGuidelineService;
import jakarta.validation.Valid;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

/* The @Validated annotation makes the autowired repository return null for some reason,
 * which means database operations can't be done because the repo doesn't work. */
//@Validated
@RestController
@RequestMapping(APIService.API_URL + "/guidelines")
public class DisposalGuidelineController {

    //Instantiating the waste repository to perform database operations in the controller
    private DisposalGuidelineService guidelineService;

    @Autowired
    public DisposalGuidelineController(DisposalGuidelineService guidelineService){
        this.guidelineService = guidelineService;
    }

    //Gets all the disposal guidelines of a given type from the database.
    @GetMapping("/{type}")
    private ResponseEntity<List<DisposalGuideline>> getGuidelines(@PathVariable String type){

        try{

            List<DisposalGuideline> allGuidelines = guidelineService.getAll();
            List<DisposalGuideline> guidelineList = new ArrayList<>();

            for (DisposalGuideline guideline : allGuidelines) {
                if (guideline.getType().equals(type.toLowerCase())) {
                    guidelineList.add(guideline);
                }
            }
            if(guidelineList.isEmpty()){
                return new ResponseEntity<>(HttpStatus.NO_CONTENT);
            }
            return new ResponseEntity<>(guidelineList, HttpStatus.OK);
        } catch (Exception ex){
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }

    //Saves a new disposal guideline into the database.
    @PostMapping(APIService.SAVE_URL)
    private ResponseEntity<DisposalGuideline> addGuideline(@Valid @RequestBody DisposalGuideline guideline)
    {
        DisposalGuideline newGuideline = guidelineService.save(guideline);
        return new ResponseEntity<>(newGuideline, HttpStatus.OK);
    }

    //Updates a disposal guideline with the given ID with the new guideline data.
    @PutMapping(APIService.UPDATE_URL)
    private ResponseEntity<DisposalGuideline> updateGuideline(@PathVariable Long id, @Valid @RequestBody DisposalGuideline newGuideline)
    {
        DisposalGuideline updatedGuideline = guidelineService.update(id, newGuideline);

        if(updatedGuideline != null){

            return new ResponseEntity<>(updatedGuideline, HttpStatus.OK);
        }
        return new ResponseEntity<>(HttpStatus.NOT_FOUND);
    }

    //Deletes a disposal guideline by the chosen ID from the database.
    @DeleteMapping(APIService.DELETE_URL)
    private ResponseEntity<HttpStatus> deleteGuideline(@PathVariable Long id)
    {
        guidelineService.deleteByID(id);
        return new ResponseEntity<>(HttpStatus.OK);
    }
}
