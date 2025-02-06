package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.controller;

import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model.DisposalGuideline;
import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.repo.DisposalGuidelineRepo;
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
public class DisposalGuidelineController {

    //Instantiating the waste repository to perform database operations in the controller
    @Autowired
    private DisposalGuidelineRepo guidelineRepo;

    //Gets all the disposal guidelines of a given type from the database.
    @GetMapping("/waste/{type}/guidelines")
    private ResponseEntity<List<DisposalGuideline>> getGuidelines(@PathVariable String type){

        try{

            List<DisposalGuideline> allGuidelines = guidelineRepo.findAll();
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
    @PostMapping("/waste/guidelines/save")
    private ResponseEntity<DisposalGuideline> addGuideline(@Valid @RequestBody DisposalGuideline guideline)
    {
        guideline.setType(guideline.getType().toLowerCase());
        DisposalGuideline newGuideline = guidelineRepo.save(guideline);

        return new ResponseEntity<>(newGuideline, HttpStatus.OK);
    }

    //Updates a disposal guideline with the given ID with the new guideline data.
    @PutMapping("/waste/guidelines/update/{id}")
    private ResponseEntity<DisposalGuideline> updateGuideline(@PathVariable Long id, @Valid @RequestBody DisposalGuideline newGuideline)
    {
        Optional<DisposalGuideline> oldGuideline = guidelineRepo.findById(id);

        if(oldGuideline.isPresent()){

            newGuideline.setType(newGuideline.getType().toLowerCase());
            DisposalGuideline updatedGuideline = oldGuideline.get();
            updatedGuideline.setDescription(newGuideline.getDescription());
            updatedGuideline.setType(newGuideline.getType());

            DisposalGuideline guidelineData = guidelineRepo.save(updatedGuideline);
            return new ResponseEntity<>(guidelineData, HttpStatus.OK);
        }

        return new ResponseEntity<>(HttpStatus.NOT_FOUND);
    }

    //Deletes a disposal guideline by the chosen ID from the database.
    @DeleteMapping("/waste/guidelines/delete/{id}")
    private ResponseEntity<HttpStatus> deleteGuideline(@PathVariable Long id)
    {
        guidelineRepo.deleteById(id);
        return new ResponseEntity<>(HttpStatus.OK);
    }
}
