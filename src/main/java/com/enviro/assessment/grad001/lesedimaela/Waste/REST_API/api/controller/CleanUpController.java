package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.controller;

import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model.CleanUp;
import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.repo.CleanUpRepo;
import jakarta.validation.Valid;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

//@Validated
@RestController
public class CleanUpController {

    @Autowired
    private CleanUpRepo cleanUpRepo;

    @GetMapping("/waste/{location}/cleanup")
    private ResponseEntity<List<CleanUp>> getCleanUpsFromLocation(@PathVariable String location){

        try{

            List<CleanUp> allCleanUps = cleanUpRepo.findAll();
            List<CleanUp> cleanUpList = new ArrayList<>();

            for (CleanUp cleanUp : allCleanUps) {
                if (cleanUp.getLocation().equals(location.toLowerCase())) {
                    cleanUpList.add(cleanUp);
                }
            }
            if(cleanUpList.isEmpty()){
                return new ResponseEntity<>(HttpStatus.NO_CONTENT);
            }
            return new ResponseEntity<>(cleanUpList, HttpStatus.OK);
        } catch (Exception ex){
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }

    @PostMapping("/waste/cleanup/save")
    private ResponseEntity<CleanUp> addCleanUp(@Valid @RequestBody CleanUp cleanUp){

        cleanUp.setLocation(cleanUp.getLocation().toLowerCase());
        CleanUp newCleanup = cleanUpRepo.save(cleanUp);
        return new ResponseEntity<>(newCleanup, HttpStatus.OK);
    }

    @PutMapping("/waste/cleanup/update/{id}")
    private ResponseEntity<CleanUp> updateCleanUp(@PathVariable Long id, @Valid @RequestBody CleanUp newCleanUp){

        Optional<CleanUp> oldCleanUp = cleanUpRepo.findById(id);

        if(oldCleanUp.isPresent()){

            if(newCleanUp.getCollectedJunk() > oldCleanUp.get().getCollectedJunk()){
                CleanUp updatedCleanup = oldCleanUp.get();
                updatedCleanup.setLocation(newCleanUp.getLocation());
                updatedCleanup.setDescription(newCleanUp.getDescription());
                updatedCleanup.setTotalJunk(newCleanUp.getTotalJunk());
                updatedCleanup.setCollectedJunk(newCleanUp.getCollectedJunk());

                CleanUp cleanUpData = cleanUpRepo.save(updatedCleanup);
                return new ResponseEntity<>(cleanUpData, HttpStatus.OK);
            }
            return new ResponseEntity<>(HttpStatus.BAD_REQUEST);
        }

        return new ResponseEntity<>(HttpStatus.NOT_FOUND);
    }

    @DeleteMapping("/waste/cleanup/delete/{id}")
    private ResponseEntity<HttpStatus> deleteCleanUp(@PathVariable Long id){

        cleanUpRepo.deleteById(id);
        return new ResponseEntity<>(HttpStatus.OK);
    }
}
